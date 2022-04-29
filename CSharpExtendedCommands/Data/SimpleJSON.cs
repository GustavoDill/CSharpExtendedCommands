using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExtendedCommands.Data
{

    namespace SimpleJSON
    {
        public enum JSONTextMode
        {
            // Token: 0x040008AD RID: 2221
            Compact,
            // Token: 0x040008AE RID: 2222
            Indent
        }
        // Token: 0x02000131 RID: 305
        public class JSONString : JSONNode
        {
            // Token: 0x060009F5 RID: 2549 RVA: 0x00042E7B File Offset: 0x0004127B
            public JSONString(string aData)
            {
                this.m_Data = aData;
            }

            // Token: 0x1700015A RID: 346
            // (get) Token: 0x060009F6 RID: 2550 RVA: 0x00042E8A File Offset: 0x0004128A
            public override JSONNodeType Tag
            {
                get
                {
                    return JSONNodeType.String;
                }
            }

            // Token: 0x1700015B RID: 347
            // (get) Token: 0x060009F7 RID: 2551 RVA: 0x00042E8D File Offset: 0x0004128D
            public override bool IsString
            {
                get
                {
                    return true;
                }
            }

            // Token: 0x1700015C RID: 348
            // (get) Token: 0x060009F8 RID: 2552 RVA: 0x00042E90 File Offset: 0x00041290
            // (set) Token: 0x060009F9 RID: 2553 RVA: 0x00042E98 File Offset: 0x00041298
            public override string Value
            {
                get
                {
                    return this.m_Data;
                }
                set
                {
                    this.m_Data = value;
                }
            }

            // Token: 0x060009FA RID: 2554 RVA: 0x00042EA1 File Offset: 0x000412A1
            public override void Serialize(System.IO.BinaryWriter aWriter)
            {
                aWriter.Write(3);
                aWriter.Write(this.m_Data);
            }

            // Token: 0x060009FB RID: 2555 RVA: 0x00042EB6 File Offset: 0x000412B6
            internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
            {
                aSB.Append('"').Append(JSONNode.Escape(this.m_Data)).Append('"');
            }

            // Token: 0x060009FC RID: 2556 RVA: 0x00042ED8 File Offset: 0x000412D8
            public override bool Equals(object obj)
            {
                if (base.Equals(obj))
                {
                    return true;
                }
                string text = obj as string;
                if (text != null)
                {
                    return this.m_Data == text;
                }
                JSONString jsonstring = obj as JSONString;
                return jsonstring != null && this.m_Data == jsonstring.m_Data;
            }

            // Token: 0x060009FD RID: 2557 RVA: 0x00042F33 File Offset: 0x00041333
            public override int GetHashCode()
            {
                return this.m_Data.GetHashCode();
            }

            // Token: 0x040008B4 RID: 2228
            private string m_Data;
        }
        // Token: 0x02000130 RID: 304
        public class JSONObject : JSONNode, IEnumerable
        {
            // Token: 0x17000154 RID: 340
            // (get) Token: 0x060009E6 RID: 2534 RVA: 0x000426FA File Offset: 0x00040AFA
            public override JSONNodeType Tag
            {
                get
                {
                    return JSONNodeType.Object;
                }
            }

            // Token: 0x17000155 RID: 341
            // (get) Token: 0x060009E7 RID: 2535 RVA: 0x000426FD File Offset: 0x00040AFD
            public override bool IsObject
            {
                get
                {
                    return true;
                }
            }

            // Token: 0x17000156 RID: 342
            public override JSONNode this[string aKey]
            {
                get
                {
                    if (this.m_Dict.ContainsKey(aKey))
                    {
                        return this.m_Dict[aKey];
                    }
                    return new JSONLazyCreator(this, aKey);
                }
                set
                {
                    if (value == null)
                    {
                        value = new JSONNull();
                    }
                    if (this.m_Dict.ContainsKey(aKey))
                    {
                        this.m_Dict[aKey] = value;
                    }
                    else
                    {
                        this.m_Dict.Add(aKey, value);
                    }
                }
            }

            // Token: 0x17000157 RID: 343
            public override JSONNode this[int aIndex]
            {
                get
                {
                    if (aIndex < 0 || aIndex >= this.m_Dict.Count)
                    {
                        return null;
                    }
                    return this.m_Dict.ElementAt(aIndex).Value;
                }
                set
                {
                    if (value == null)
                    {
                        value = new JSONNull();
                    }
                    if (aIndex < 0 || aIndex >= this.m_Dict.Count)
                    {
                        return;
                    }
                    string key = this.m_Dict.ElementAt(aIndex).Key;
                    this.m_Dict[key] = value;
                }
            }

            // Token: 0x17000158 RID: 344
            // (get) Token: 0x060009EC RID: 2540 RVA: 0x0004280F File Offset: 0x00040C0F
            public override int Count
            {
                get
                {
                    return this.m_Dict.Count;
                }
            }

            // Token: 0x060009ED RID: 2541 RVA: 0x0004281C File Offset: 0x00040C1C
            public override void Add(string aKey, JSONNode aItem)
            {
                if (aItem == null)
                {
                    aItem = new JSONNull();
                }
                if (!string.IsNullOrEmpty(aKey))
                {
                    if (this.m_Dict.ContainsKey(aKey))
                    {
                        this.m_Dict[aKey] = aItem;
                    }
                    else
                    {
                        this.m_Dict.Add(aKey, aItem);
                    }
                }
                else
                {
                    this.m_Dict.Add(Guid.NewGuid().ToString(), aItem);
                }
            }

            // Token: 0x060009EE RID: 2542 RVA: 0x0004289C File Offset: 0x00040C9C
            public override JSONNode Remove(string aKey)
            {
                if (!this.m_Dict.ContainsKey(aKey))
                {
                    return null;
                }
                JSONNode result = this.m_Dict[aKey];
                this.m_Dict.Remove(aKey);
                return result;
            }

            // Token: 0x060009EF RID: 2543 RVA: 0x000428D8 File Offset: 0x00040CD8
            public override JSONNode Remove(int aIndex)
            {
                if (aIndex < 0 || aIndex >= this.m_Dict.Count)
                {
                    return null;
                }
                KeyValuePair<string, JSONNode> keyValuePair = this.m_Dict.ElementAt(aIndex);
                this.m_Dict.Remove(keyValuePair.Key);
                return keyValuePair.Value;
            }

            // Token: 0x060009F0 RID: 2544 RVA: 0x00042928 File Offset: 0x00040D28
            public override JSONNode Remove(JSONNode aNode)
            {
                JSONNode result;
                try
                {
                    KeyValuePair<string, JSONNode> keyValuePair = (from k in this.m_Dict
                                                                   where k.Value == aNode
                                                                   select k).First<KeyValuePair<string, JSONNode>>();
                    this.m_Dict.Remove(keyValuePair.Key);
                    result = aNode;
                }
                catch
                {
                    result = null;
                }
                return result;
            }

            // Token: 0x17000159 RID: 345
            // (get) Token: 0x060009F1 RID: 2545 RVA: 0x00042998 File Offset: 0x00040D98
            public override IEnumerable<JSONNode> Children
            {
                get
                {
                    foreach (KeyValuePair<string, JSONNode> N in this.m_Dict)
                    {
                        yield return N.Value;
                    }
                    yield break;
                }
            }

            // Token: 0x060009F2 RID: 2546 RVA: 0x000429BC File Offset: 0x00040DBC
            public IEnumerator GetEnumerator()
            {
                foreach (KeyValuePair<string, JSONNode> N in this.m_Dict)
                {
                    yield return N;
                }
                yield break;
            }

            // Token: 0x060009F3 RID: 2547 RVA: 0x000429D8 File Offset: 0x00040DD8
            public override void Serialize(System.IO.BinaryWriter aWriter)
            {
                aWriter.Write(2);
                aWriter.Write(this.m_Dict.Count);
                foreach (string text in this.m_Dict.Keys)
                {
                    aWriter.Write(text);
                    this.m_Dict[text].Serialize(aWriter);
                }
            }

            // Token: 0x060009F4 RID: 2548 RVA: 0x00042A64 File Offset: 0x00040E64
            internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
            {
                aSB.Append('{');
                bool flag = true;
                if (this.inline)
                {
                    aMode = JSONTextMode.Compact;
                }
                foreach (KeyValuePair<string, JSONNode> keyValuePair in this.m_Dict)
                {
                    if (!flag)
                    {
                        aSB.Append(',');
                    }
                    flag = false;
                    if (aMode == JSONTextMode.Indent)
                    {
                        aSB.AppendLine();
                    }
                    if (aMode == JSONTextMode.Indent)
                    {
                        aSB.Append(' ', aIndent + aIndentInc);
                    }
                    aSB.Append('"').Append(JSONNode.Escape(keyValuePair.Key)).Append('"');
                    if (aMode == JSONTextMode.Compact)
                    {
                        aSB.Append(':');
                    }
                    else
                    {
                        aSB.Append(" : ");
                    }
                    keyValuePair.Value.WriteToStringBuilder(aSB, aIndent + aIndentInc, aIndentInc, aMode);
                }
                if (aMode == JSONTextMode.Indent)
                {
                    aSB.AppendLine().Append(' ', aIndent);
                }
                aSB.Append('}');
            }

            // Token: 0x040008B2 RID: 2226
            private Dictionary<string, JSONNode> m_Dict = new Dictionary<string, JSONNode>();

            // Token: 0x040008B3 RID: 2227
            public bool inline;
        }
        // Token: 0x02000132 RID: 306
        public class JSONNumber : JSONNode
        {
            // Token: 0x060009FE RID: 2558 RVA: 0x00042F40 File Offset: 0x00041340
            public JSONNumber(double aData)
            {
                this.m_Data = aData;
            }

            // Token: 0x060009FF RID: 2559 RVA: 0x00042F4F File Offset: 0x0004134F
            public JSONNumber(string aData)
            {
                this.Value = aData;
            }

            // Token: 0x1700015D RID: 349
            // (get) Token: 0x06000A00 RID: 2560 RVA: 0x00042F5E File Offset: 0x0004135E
            public override JSONNodeType Tag
            {
                get
                {
                    return JSONNodeType.Number;
                }
            }

            // Token: 0x1700015E RID: 350
            // (get) Token: 0x06000A01 RID: 2561 RVA: 0x00042F61 File Offset: 0x00041361
            public override bool IsNumber
            {
                get
                {
                    return true;
                }
            }

            // Token: 0x1700015F RID: 351
            // (get) Token: 0x06000A02 RID: 2562 RVA: 0x00042F64 File Offset: 0x00041364
            // (set) Token: 0x06000A03 RID: 2563 RVA: 0x00042F78 File Offset: 0x00041378
            public override string Value
            {
                get
                {
                    return this.m_Data.ToString();
                }
                set
                {
                    double data;
                    if (double.TryParse(value, out data))
                    {
                        this.m_Data = data;
                    }
                }
            }

            // Token: 0x17000160 RID: 352
            // (get) Token: 0x06000A04 RID: 2564 RVA: 0x00042F99 File Offset: 0x00041399
            // (set) Token: 0x06000A05 RID: 2565 RVA: 0x00042FA1 File Offset: 0x000413A1
            public override double AsDouble
            {
                get
                {
                    return this.m_Data;
                }
                set
                {
                    this.m_Data = value;
                }
            }

            // Token: 0x06000A06 RID: 2566 RVA: 0x00042FAA File Offset: 0x000413AA
            public override void Serialize(System.IO.BinaryWriter aWriter)
            {
                aWriter.Write(4);
                aWriter.Write(this.m_Data);
            }

            // Token: 0x06000A07 RID: 2567 RVA: 0x00042FBF File Offset: 0x000413BF
            internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
            {
                aSB.Append(this.m_Data);
            }

            // Token: 0x06000A08 RID: 2568 RVA: 0x00042FD0 File Offset: 0x000413D0
            private static bool IsNumeric(object value)
            {
                return value is int || value is uint || value is float || value is double || value is decimal || value is long || value is ulong || value is short || value is ushort || value is sbyte || value is byte;
            }

            // Token: 0x06000A09 RID: 2569 RVA: 0x00043058 File Offset: 0x00041458
            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }
                if (base.Equals(obj))
                {
                    return true;
                }
                JSONNumber jsonnumber = obj as JSONNumber;
                if (jsonnumber != null)
                {
                    return this.m_Data == jsonnumber.m_Data;
                }
                return JSONNumber.IsNumeric(obj) && Convert.ToDouble(obj) == this.m_Data;
            }

            // Token: 0x06000A0A RID: 2570 RVA: 0x000430B8 File Offset: 0x000414B8
            public override int GetHashCode()
            {
                return this.m_Data.GetHashCode();
            }

            // Token: 0x040008B5 RID: 2229
            private double m_Data;
        }
        // Token: 0x02000134 RID: 308
        public class JSONNull : JSONNode
        {
            // Token: 0x17000165 RID: 357
            // (get) Token: 0x06000A18 RID: 2584 RVA: 0x000431AE File Offset: 0x000415AE
            public override JSONNodeType Tag
            {
                get
                {
                    return JSONNodeType.NullValue;
                }
            }

            // Token: 0x17000166 RID: 358
            // (get) Token: 0x06000A19 RID: 2585 RVA: 0x000431B1 File Offset: 0x000415B1
            public override bool IsNull
            {
                get
                {
                    return true;
                }
            }

            // Token: 0x17000167 RID: 359
            // (get) Token: 0x06000A1A RID: 2586 RVA: 0x000431B4 File Offset: 0x000415B4
            // (set) Token: 0x06000A1B RID: 2587 RVA: 0x000431BB File Offset: 0x000415BB
            public override string Value
            {
                get
                {
                    return "null";
                }
                set
                {
                }
            }

            // Token: 0x17000168 RID: 360
            // (get) Token: 0x06000A1C RID: 2588 RVA: 0x000431BD File Offset: 0x000415BD
            // (set) Token: 0x06000A1D RID: 2589 RVA: 0x000431C0 File Offset: 0x000415C0
            public override bool AsBool
            {
                get
                {
                    return false;
                }
                set
                {
                }
            }

            // Token: 0x06000A1E RID: 2590 RVA: 0x000431C2 File Offset: 0x000415C2
            public override bool Equals(object obj)
            {
                return object.ReferenceEquals(this, obj) || obj is JSONNull;
            }

            // Token: 0x06000A1F RID: 2591 RVA: 0x000431DB File Offset: 0x000415DB
            public override int GetHashCode()
            {
                return 0;
            }

            // Token: 0x06000A20 RID: 2592 RVA: 0x000431DE File Offset: 0x000415DE
            public override void Serialize(System.IO.BinaryWriter aWriter)
            {
                aWriter.Write(5);
            }

            // Token: 0x06000A21 RID: 2593 RVA: 0x000431E7 File Offset: 0x000415E7
            internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
            {
                aSB.Append("null");
            }
        }
        public enum JSONNodeType
        {
            // Token: 0x040008A5 RID: 2213
            Array = 1,
            // Token: 0x040008A6 RID: 2214
            Object,
            // Token: 0x040008A7 RID: 2215
            String,
            // Token: 0x040008A8 RID: 2216
            Number,
            // Token: 0x040008A9 RID: 2217
            NullValue,
            // Token: 0x040008AA RID: 2218
            Boolean,
            // Token: 0x040008AB RID: 2219
            None
        }
        public static class JSONNodeExtension
        {
            public static JSONNode Locate(this JSONNode node, string path)
            {
                var n = node;
                foreach (var v in path.Split('/'))
                    try { n = n[int.Parse(v)]; }
                    catch { n = n[v]; }
                return n;
            }
            public static string Formatted(this JSONNode node)
            {
                return JSON.Format(node.ToString());
            }
        }
        // Token: 0x0200012E RID: 302
        public abstract class JSONNode
        {
            // Token: 0x1700013B RID: 315
            public virtual JSONNode this[int aIndex]
            {
                get
                {
                    return null;
                }
                set
                {
                }
            }

            // Token: 0x1700013C RID: 316
            public virtual JSONNode this[string aKey]
            {
                get
                {
                    return null;
                }
                set
                {
                }
            }
            public virtual string Value
            {
                get
                {
                    return string.Empty;
                }
                set
                {
                }
            }
            public virtual int Count
            {
                get
                {
                    return 0;
                }
            }
            public virtual bool IsNumber
            {
                get
                {
                    return false;
                }
            }
            public virtual bool IsString
            {
                get
                {
                    return false;
                }
            }
            public virtual bool IsBoolean
            {
                get
                {
                    return false;
                }
            }
            public virtual bool IsNull
            {
                get
                {
                    return false;
                }
            }
            public virtual bool IsArray
            {
                get
                {
                    return false;
                }
            }
            public virtual bool IsObject
            {
                get
                {
                    return false;
                }
            }
            public virtual void Add(string aKey, JSONNode aItem)
            {
            }
            public virtual void Add(JSONNode aItem)
            {
                this.Add(string.Empty, aItem);
            }
            public virtual JSONNode Remove(string aKey)
            {
                return null;
            }
            public virtual JSONNode Remove(int aIndex)
            {
                return null;
            }
            public virtual JSONNode Remove(JSONNode aNode)
            {
                return aNode;
            }
            public virtual IEnumerable<JSONNode> Children
            {
                get
                {
                    yield break;
                }
            }
            public IEnumerable<JSONNode> DeepChildren
            {
                get
                {
                    foreach (JSONNode C in this.Children)
                    {
                        foreach (JSONNode D in C.DeepChildren)
                        {
                            yield return D;
                        }
                    }
                    yield break;
                }
            }
            public override string ToString()
            {
                StringBuilder stringBuilder = new StringBuilder();
                this.WriteToStringBuilder(stringBuilder, 0, 0, JSONTextMode.Compact);
                return stringBuilder.ToString();
            }
            public virtual string ToString(int aIndent)
            {
                StringBuilder stringBuilder = new StringBuilder();
                this.WriteToStringBuilder(stringBuilder, 0, aIndent, JSONTextMode.Indent);
                return stringBuilder.ToString();
            }
            internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);
            public abstract JSONNodeType Tag { get; }
            public virtual double AsDouble
            {
                get
                {
                    double result = 0.0;
                    if (double.TryParse(this.Value, out result))
                    {
                        return result;
                    }
                    return 0.0;
                }
                set
                {
                    this.Value = value.ToString();
                }
            }
            public virtual int AsInt
            {
                get
                {
                    return (int)this.AsDouble;
                }
                set
                {
                    this.AsDouble = (double)value;
                }
            }
            public virtual float AsFloat
            {
                get
                {
                    return (float)this.AsDouble;
                }
                set
                {
                    this.AsDouble = (double)value;
                }
            }
            public virtual bool AsBool
            {
                get
                {
                    bool result = false;
                    if (bool.TryParse(this.Value, out result))
                    {
                        return result;
                    }
                    return !string.IsNullOrEmpty(this.Value);
                }
                set
                {
                    this.Value = ((!value) ? "false" : "true");
                }
            }
            public virtual JSONArray AsArray
            {
                get
                {
                    return this as JSONArray;
                }
            }
            public virtual JSONObject AsObject
            {
                get
                {
                    return this as JSONObject;
                }
            }
            public static implicit operator JSONNode(string s)
            {
                return new JSONString(s);
            }
            public static implicit operator string(JSONNode d)
            {
                return (!(d == null)) ? d.Value : null;
            }
            public static implicit operator JSONNode(double n)
            {
                return new JSONNumber(n);
            }
            public static implicit operator double(JSONNode d)
            {
                return (!(d == null)) ? d.AsDouble : 0.0;
            }
            public static implicit operator JSONNode(float n)
            {
                return new JSONNumber((double)n);
            }
            public static implicit operator float(JSONNode d)
            {
                return (!(d == null)) ? d.AsFloat : 0f;
            }
            public static implicit operator JSONNode(int n)
            {
                return new JSONNumber((double)n);
            }
            public static implicit operator int(JSONNode d)
            {
                return (!(d == null)) ? d.AsInt : 0;
            }
            public static implicit operator JSONNode(bool b)
            {
                return new JSONBool(b);
            }
            public static implicit operator bool(JSONNode d)
            {
                return !(d == null) && d.AsBool;
            }
            public static bool operator ==(JSONNode a, object b)
            {
                if (object.ReferenceEquals(a, b))
                {
                    return true;
                }
                bool flag = a is JSONNull || object.ReferenceEquals(a, null) || a is JSONLazyCreator;
                bool flag2 = b is JSONNull || object.ReferenceEquals(b, null) || b is JSONLazyCreator;
                return (flag && flag2) || a.Equals(b);
            }
            public static bool operator !=(JSONNode a, object b)
            {
                return !(a == b);
            }
            public override bool Equals(object obj)
            {
                return object.ReferenceEquals(this, obj);
            }
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
            internal static string Escape(string aText)
            {
                JSONNode.m_EscapeBuilder.Length = 0;
                if (JSONNode.m_EscapeBuilder.Capacity < aText.Length + aText.Length / 10)
                {
                    JSONNode.m_EscapeBuilder.Capacity = aText.Length + aText.Length / 10;
                }
                foreach (char c in aText)
                {
                    switch (c)
                    {
                        case '\b':
                            JSONNode.m_EscapeBuilder.Append("\\b");
                            break;
                        case '\t':
                            JSONNode.m_EscapeBuilder.Append("\\t");
                            break;
                        case '\n':
                            JSONNode.m_EscapeBuilder.Append("\\n");
                            break;
                        default:
                            if (c != '"')
                            {
                                if (c != '\\')
                                {
                                    JSONNode.m_EscapeBuilder.Append(c);
                                }
                                else
                                {
                                    JSONNode.m_EscapeBuilder.Append("\\\\");
                                }
                            }
                            else
                            {
                                JSONNode.m_EscapeBuilder.Append("\\\"");
                            }
                            break;
                        case '\f':
                            JSONNode.m_EscapeBuilder.Append("\\f");
                            break;
                        case '\r':
                            JSONNode.m_EscapeBuilder.Append("\\r");
                            break;
                    }
                }
                string result = JSONNode.m_EscapeBuilder.ToString();
                JSONNode.m_EscapeBuilder.Length = 0;
                return result;
            }

            // Token: 0x060009C5 RID: 2501 RVA: 0x000417E4 File Offset: 0x0003FBE4
            private static void ParseElement(JSONNode ctx, string token, string tokenName, bool quoted)
            {
                if (quoted)
                {
                    ctx.Add(tokenName, token);
                    return;
                }
                string a = token.ToLower();
                double n;
                if (a == "false" || a == "true")
                {
                    ctx.Add(tokenName, a == "true");
                }
                else if (a == "null")
                {
                    ctx.Add(tokenName, null);
                }
                else if (double.TryParse(token, out n))
                {
                    ctx.Add(tokenName, n);
                }
                else
                {
                    ctx.Add(tokenName, token);
                }
            }

            // Token: 0x060009C6 RID: 2502 RVA: 0x00041894 File Offset: 0x0003FC94
            public static JSONNode Parse(string aJSON)
            {
                Stack<JSONNode> stack = new Stack<JSONNode>();
                JSONNode jsonnode = null;
                int i = 0;
                StringBuilder stringBuilder = new StringBuilder();
                string text = string.Empty;
                bool flag = false;
                bool flag2 = false;
                while (i < aJSON.Length)
                {
                    char c = aJSON[i];
                    switch (c)
                    {
                        case '\t':
                            goto IL_275;
                        case '\n':
                        case '\r':
                            break;
                        default:
                            switch (c)
                            {
                                case '[':
                                    if (flag)
                                    {
                                        stringBuilder.Append(aJSON[i]);
                                        goto IL_371;
                                    }
                                    stack.Push(new JSONArray());
                                    if (jsonnode != null)
                                    {
                                        jsonnode.Add(text, stack.Peek());
                                    }
                                    text = string.Empty;
                                    stringBuilder.Length = 0;
                                    jsonnode = stack.Peek();
                                    goto IL_371;
                                case '\\':
                                    i++;
                                    if (flag)
                                    {
                                        char c2 = aJSON[i];
                                        switch (c2)
                                        {
                                            case 'r':
                                                stringBuilder.Append('\r');
                                                break;
                                            default:
                                                if (c2 != 'b')
                                                {
                                                    if (c2 != 'f')
                                                    {
                                                        if (c2 != 'n')
                                                        {
                                                            stringBuilder.Append(c2);
                                                        }
                                                        else
                                                        {
                                                            stringBuilder.Append('\n');
                                                        }
                                                    }
                                                    else
                                                    {
                                                        stringBuilder.Append('\f');
                                                    }
                                                }
                                                else
                                                {
                                                    stringBuilder.Append('\b');
                                                }
                                                break;
                                            case 't':
                                                stringBuilder.Append('\t');
                                                break;
                                            case 'u':
                                                {
                                                    string s = aJSON.Substring(i + 1, 4);
                                                    stringBuilder.Append((char)int.Parse(s, NumberStyles.AllowHexSpecifier));
                                                    i += 4;
                                                    break;
                                                }
                                        }
                                    }
                                    goto IL_371;
                                case ']':
                                    break;
                                default:
                                    switch (c)
                                    {
                                        case ' ':
                                            goto IL_275;
                                        default:
                                            switch (c)
                                            {
                                                case '{':
                                                    if (flag)
                                                    {
                                                        stringBuilder.Append(aJSON[i]);
                                                        goto IL_371;
                                                    }
                                                    stack.Push(new JSONObject());
                                                    if (jsonnode != null)
                                                    {
                                                        jsonnode.Add(text, stack.Peek());
                                                    }
                                                    text = string.Empty;
                                                    stringBuilder.Length = 0;
                                                    jsonnode = stack.Peek();
                                                    goto IL_371;
                                                default:
                                                    if (c != ',')
                                                    {
                                                        if (c != ':')
                                                        {
                                                            stringBuilder.Append(aJSON[i]);
                                                            goto IL_371;
                                                        }
                                                        if (flag)
                                                        {
                                                            stringBuilder.Append(aJSON[i]);
                                                            goto IL_371;
                                                        }
                                                        text = stringBuilder.ToString();
                                                        stringBuilder.Length = 0;
                                                        flag2 = false;
                                                        goto IL_371;
                                                    }
                                                    else
                                                    {
                                                        if (flag)
                                                        {
                                                            stringBuilder.Append(aJSON[i]);
                                                            goto IL_371;
                                                        }
                                                        if (stringBuilder.Length > 0 || flag2)
                                                        {
                                                            JSONNode.ParseElement(jsonnode, stringBuilder.ToString(), text, flag2);
                                                        }
                                                        text = string.Empty;
                                                        stringBuilder.Length = 0;
                                                        flag2 = false;
                                                        goto IL_371;
                                                    }
                                                case '}':
                                                    break;
                                            }
                                            break;
                                        case '"':
                                            flag ^= true;
                                            flag2 = (flag2 || flag);
                                            goto IL_371;
                                    }
                                    break;
                            }
                            if (flag)
                            {
                                stringBuilder.Append(aJSON[i]);
                            }
                            else
                            {
                                if (stack.Count == 0)
                                {
                                    throw new Exception("JSON Parse: Too many closing brackets");
                                }
                                stack.Pop();
                                if (stringBuilder.Length > 0 || flag2)
                                {
                                    JSONNode.ParseElement(jsonnode, stringBuilder.ToString(), text, flag2);
                                    flag2 = false;
                                }
                                text = string.Empty;
                                stringBuilder.Length = 0;
                                if (stack.Count > 0)
                                {
                                    jsonnode = stack.Peek();
                                }
                            }
                            break;
                    }
                IL_371:
                    i++;
                    continue;
                IL_275:
                    if (flag)
                    {
                        stringBuilder.Append(aJSON[i]);
                    }
                    goto IL_371;
                }
                if (flag)
                {
                    throw new Exception("JSON Parse: Quotation marks seems to be messed up.");
                }
                return jsonnode;
            }

            // Token: 0x060009C7 RID: 2503 RVA: 0x00041C35 File Offset: 0x00040035
            public virtual void Serialize(System.IO.BinaryWriter aWriter)
            {
            }

            // Token: 0x060009C8 RID: 2504 RVA: 0x00041C38 File Offset: 0x00040038
            public void SaveToStream(System.IO.Stream aData)
            {
                System.IO.BinaryWriter aWriter = new System.IO.BinaryWriter(aData);
                this.Serialize(aWriter);
            }

            // Token: 0x060009C9 RID: 2505 RVA: 0x00041C53 File Offset: 0x00040053
            public void SaveToCompressedStream(System.IO.Stream aData)
            {
                throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
            }

            // Token: 0x060009CA RID: 2506 RVA: 0x00041C5F File Offset: 0x0004005F
            public void SaveToCompressedFile(string aFileName)
            {
                throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
            }

            // Token: 0x060009CB RID: 2507 RVA: 0x00041C6B File Offset: 0x0004006B
            public string SaveToCompressedBase64()
            {
                throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
            }

            // Token: 0x060009CC RID: 2508 RVA: 0x00041C78 File Offset: 0x00040078
            public void SaveToFile(string aFileName)
            {
                System.IO.Directory.CreateDirectory(new System.IO.FileInfo(aFileName).Directory.FullName);
                using (System.IO.FileStream fileStream = System.IO.File.OpenWrite(aFileName))
                {
                    this.SaveToStream(fileStream);
                }
            }

            // Token: 0x060009CD RID: 2509 RVA: 0x00041CCC File Offset: 0x000400CC
            public string SaveToBase64()
            {
                string result;
                using (System.IO.MemoryStream memoryStream = new System.IO.MemoryStream())
                {
                    this.SaveToStream(memoryStream);
                    memoryStream.Position = 0L;
                    result = Convert.ToBase64String(memoryStream.ToArray());
                }
                return result;
            }

            // Token: 0x060009CE RID: 2510 RVA: 0x00041D20 File Offset: 0x00040120
            public static JSONNode Deserialize(System.IO.BinaryReader aReader)
            {
                JSONNodeType jsonnodeType = (JSONNodeType)aReader.ReadByte();
                switch (jsonnodeType)
                {
                    case JSONNodeType.Array:
                        {
                            int num = aReader.ReadInt32();
                            JSONArray jsonarray = new JSONArray();
                            for (int i = 0; i < num; i++)
                            {
                                jsonarray.Add(JSONNode.Deserialize(aReader));
                            }
                            return jsonarray;
                        }
                    case JSONNodeType.Object:
                        {
                            int num2 = aReader.ReadInt32();
                            JSONObject jsonobject = new JSONObject();
                            for (int j = 0; j < num2; j++)
                            {
                                string aKey = aReader.ReadString();
                                JSONNode aItem = JSONNode.Deserialize(aReader);
                                jsonobject.Add(aKey, aItem);
                            }
                            return jsonobject;
                        }
                    case JSONNodeType.String:
                        return new JSONString(aReader.ReadString());
                    case JSONNodeType.Number:
                        return new JSONNumber(aReader.ReadDouble());
                    case JSONNodeType.NullValue:
                        return new JSONNull();
                    case JSONNodeType.Boolean:
                        return new JSONBool(aReader.ReadBoolean());
                    default:
                        throw new Exception("Error deserializing JSON. Unknown tag: " + jsonnodeType);
                }
            }

            // Token: 0x060009CF RID: 2511 RVA: 0x00041E09 File Offset: 0x00040209
            public static JSONNode LoadFromCompressedFile(string aFileName)
            {
                throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
            }

            // Token: 0x060009D0 RID: 2512 RVA: 0x00041E15 File Offset: 0x00040215
            public static JSONNode LoadFromCompressedStream(System.IO.Stream aData)
            {
                throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
            }

            // Token: 0x060009D1 RID: 2513 RVA: 0x00041E21 File Offset: 0x00040221
            public static JSONNode LoadFromCompressedBase64(string aBase64)
            {
                throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
            }

            // Token: 0x060009D2 RID: 2514 RVA: 0x00041E30 File Offset: 0x00040230
            public static JSONNode LoadFromStream(System.IO.Stream aData)
            {
                JSONNode result;
                using (System.IO.BinaryReader binaryReader = new System.IO.BinaryReader(aData))
                {
                    result = JSONNode.Deserialize(binaryReader);
                }
                return result;
            }

            // Token: 0x060009D3 RID: 2515 RVA: 0x00041E70 File Offset: 0x00040270
            public static JSONNode LoadFromFile(string aFileName)
            {
                JSONNode result;
                using (System.IO.FileStream fileStream = System.IO.File.OpenRead(aFileName))
                {
                    result = JSONNode.LoadFromStream(fileStream);
                }
                return result;
            }

            // Token: 0x060009D4 RID: 2516 RVA: 0x00041EB0 File Offset: 0x000402B0
            public static JSONNode LoadFromBase64(string aBase64)
            {
                byte[] buffer = Convert.FromBase64String(aBase64);
                return JSONNode.LoadFromStream(new System.IO.MemoryStream(buffer)
                {
                    Position = 0L
                });
            }

            // Token: 0x040008AF RID: 2223
            internal static StringBuilder m_EscapeBuilder = new StringBuilder();
        }
        // Token: 0x02000135 RID: 309
        internal class JSONLazyCreator : JSONNode
        {
            // Token: 0x06000A22 RID: 2594 RVA: 0x000431F5 File Offset: 0x000415F5
            public JSONLazyCreator(JSONNode aNode)
            {
                this.m_Node = aNode;
                this.m_Key = null;
            }

            // Token: 0x06000A23 RID: 2595 RVA: 0x0004320B File Offset: 0x0004160B
            public JSONLazyCreator(JSONNode aNode, string aKey)
            {
                this.m_Node = aNode;
                this.m_Key = aKey;
            }

            // Token: 0x17000169 RID: 361
            // (get) Token: 0x06000A24 RID: 2596 RVA: 0x00043221 File Offset: 0x00041621
            public override JSONNodeType Tag
            {
                get
                {
                    return JSONNodeType.None;
                }
            }

            // Token: 0x06000A25 RID: 2597 RVA: 0x00043224 File Offset: 0x00041624
            private void Set(JSONNode aVal)
            {
                if (this.m_Key == null)
                {
                    this.m_Node.Add(aVal);
                }
                else
                {
                    this.m_Node.Add(this.m_Key, aVal);
                }
                this.m_Node = null;
            }

            // Token: 0x1700016A RID: 362
            public override JSONNode this[int aIndex]
            {
                get
                {
                    return new JSONLazyCreator(this);
                }
                set
                {
                    this.Set(new JSONArray
                {
                    value
                });
                }
            }

            // Token: 0x1700016B RID: 363
            public override JSONNode this[string aKey]
            {
                get
                {
                    return new JSONLazyCreator(this, aKey);
                }
                set
                {
                    this.Set(new JSONObject
                {
                    {
                        aKey,
                        value
                    }
                });
                }
            }

            // Token: 0x06000A2A RID: 2602 RVA: 0x000432B4 File Offset: 0x000416B4
            public override void Add(JSONNode aItem)
            {
                this.Set(new JSONArray
            {
                aItem
            });
            }

            // Token: 0x06000A2B RID: 2603 RVA: 0x000432D8 File Offset: 0x000416D8
            public override void Add(string aKey, JSONNode aItem)
            {
                this.Set(new JSONObject
            {
                {
                    aKey,
                    aItem
                }
            });
            }

            // Token: 0x06000A2C RID: 2604 RVA: 0x000432FA File Offset: 0x000416FA
            public static bool operator ==(JSONLazyCreator a, object b)
            {
                return b == null || object.ReferenceEquals(a, b);
            }

            // Token: 0x06000A2D RID: 2605 RVA: 0x0004330B File Offset: 0x0004170B
            public static bool operator !=(JSONLazyCreator a, object b)
            {
                return !(a == b);
            }

            // Token: 0x06000A2E RID: 2606 RVA: 0x00043317 File Offset: 0x00041717
            public override bool Equals(object obj)
            {
                return obj == null || object.ReferenceEquals(this, obj);
            }

            // Token: 0x06000A2F RID: 2607 RVA: 0x00043328 File Offset: 0x00041728
            public override int GetHashCode()
            {
                return 0;
            }

            // Token: 0x1700016C RID: 364
            // (get) Token: 0x06000A30 RID: 2608 RVA: 0x0004332C File Offset: 0x0004172C
            // (set) Token: 0x06000A31 RID: 2609 RVA: 0x00043350 File Offset: 0x00041750
            public override int AsInt
            {
                get
                {
                    JSONNumber aVal = new JSONNumber(0.0);
                    this.Set(aVal);
                    return 0;
                }
                set
                {
                    JSONNumber aVal = new JSONNumber((double)value);
                    this.Set(aVal);
                }
            }

            // Token: 0x1700016D RID: 365
            // (get) Token: 0x06000A32 RID: 2610 RVA: 0x0004336C File Offset: 0x0004176C
            // (set) Token: 0x06000A33 RID: 2611 RVA: 0x00043394 File Offset: 0x00041794
            public override float AsFloat
            {
                get
                {
                    JSONNumber aVal = new JSONNumber(0.0);
                    this.Set(aVal);
                    return 0f;
                }
                set
                {
                    JSONNumber aVal = new JSONNumber((double)value);
                    this.Set(aVal);
                }
            }

            // Token: 0x1700016E RID: 366
            // (get) Token: 0x06000A34 RID: 2612 RVA: 0x000433B0 File Offset: 0x000417B0
            // (set) Token: 0x06000A35 RID: 2613 RVA: 0x000433DC File Offset: 0x000417DC
            public override double AsDouble
            {
                get
                {
                    JSONNumber aVal = new JSONNumber(0.0);
                    this.Set(aVal);
                    return 0.0;
                }
                set
                {
                    JSONNumber aVal = new JSONNumber(value);
                    this.Set(aVal);
                }
            }

            // Token: 0x1700016F RID: 367
            // (get) Token: 0x06000A36 RID: 2614 RVA: 0x000433F8 File Offset: 0x000417F8
            // (set) Token: 0x06000A37 RID: 2615 RVA: 0x00043414 File Offset: 0x00041814
            public override bool AsBool
            {
                get
                {
                    JSONBool aVal = new JSONBool(false);
                    this.Set(aVal);
                    return false;
                }
                set
                {
                    JSONBool aVal = new JSONBool(value);
                    this.Set(aVal);
                }
            }

            // Token: 0x17000170 RID: 368
            // (get) Token: 0x06000A38 RID: 2616 RVA: 0x00043430 File Offset: 0x00041830
            public override JSONArray AsArray
            {
                get
                {
                    JSONArray jsonarray = new JSONArray();
                    this.Set(jsonarray);
                    return jsonarray;
                }
            }

            // Token: 0x17000171 RID: 369
            // (get) Token: 0x06000A39 RID: 2617 RVA: 0x0004344C File Offset: 0x0004184C
            public override JSONObject AsObject
            {
                get
                {
                    JSONObject jsonobject = new JSONObject();
                    this.Set(jsonobject);
                    return jsonobject;
                }
            }

            // Token: 0x06000A3A RID: 2618 RVA: 0x00043467 File Offset: 0x00041867
            internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
            {
                aSB.Append("null");
            }

            // Token: 0x040008B7 RID: 2231
            private JSONNode m_Node;

            // Token: 0x040008B8 RID: 2232
            private string m_Key;
        }
        // Token: 0x02000133 RID: 307
        public class JSONBool : JSONNode
        {
            // Token: 0x06000A0B RID: 2571 RVA: 0x000430CB File Offset: 0x000414CB
            public JSONBool(bool aData)
            {
                this.m_Data = aData;
            }

            // Token: 0x06000A0C RID: 2572 RVA: 0x000430DA File Offset: 0x000414DA
            public JSONBool(string aData)
            {
                this.Value = aData;
            }

            // Token: 0x17000161 RID: 353
            // (get) Token: 0x06000A0D RID: 2573 RVA: 0x000430E9 File Offset: 0x000414E9
            public override JSONNodeType Tag
            {
                get
                {
                    return JSONNodeType.Boolean;
                }
            }

            // Token: 0x17000162 RID: 354
            // (get) Token: 0x06000A0E RID: 2574 RVA: 0x000430EC File Offset: 0x000414EC
            public override bool IsBoolean
            {
                get
                {
                    return true;
                }
            }

            // Token: 0x17000163 RID: 355
            // (get) Token: 0x06000A0F RID: 2575 RVA: 0x000430EF File Offset: 0x000414EF
            // (set) Token: 0x06000A10 RID: 2576 RVA: 0x00043104 File Offset: 0x00041504
            public override string Value
            {
                get
                {
                    return this.m_Data.ToString();
                }
                set
                {
                    bool data;
                    if (bool.TryParse(value, out data))
                    {
                        this.m_Data = data;
                    }
                }
            }

            // Token: 0x17000164 RID: 356
            // (get) Token: 0x06000A11 RID: 2577 RVA: 0x00043125 File Offset: 0x00041525
            // (set) Token: 0x06000A12 RID: 2578 RVA: 0x0004312D File Offset: 0x0004152D
            public override bool AsBool
            {
                get
                {
                    return this.m_Data;
                }
                set
                {
                    this.m_Data = value;
                }
            }

            // Token: 0x06000A13 RID: 2579 RVA: 0x00043136 File Offset: 0x00041536
            public override void Serialize(System.IO.BinaryWriter aWriter)
            {
                aWriter.Write(6);
                aWriter.Write(this.m_Data);
            }

            // Token: 0x06000A14 RID: 2580 RVA: 0x0004314B File Offset: 0x0004154B
            internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
            {
                aSB.Append((!this.m_Data) ? "false" : "true");
            }

            // Token: 0x06000A15 RID: 2581 RVA: 0x0004316E File Offset: 0x0004156E
            public override bool Equals(object obj)
            {
                return obj != null && obj is bool && this.m_Data == (bool)obj;
            }

            // Token: 0x06000A16 RID: 2582 RVA: 0x00043193 File Offset: 0x00041593
            public override int GetHashCode()
            {
                return this.m_Data.GetHashCode();
            }

            // Token: 0x040008B6 RID: 2230
            private bool m_Data;
        }
        // Token: 0x0200012F RID: 303
        public class JSONArray : JSONNode, IEnumerable
        {
            // Token: 0x1700014E RID: 334
            // (get) Token: 0x060009D7 RID: 2519 RVA: 0x0004218F File Offset: 0x0004058F
            public override JSONNodeType Tag
            {
                get
                {
                    return JSONNodeType.Array;
                }
            }

            // Token: 0x1700014F RID: 335
            // (get) Token: 0x060009D8 RID: 2520 RVA: 0x00042192 File Offset: 0x00040592
            public override bool IsArray
            {
                get
                {
                    return true;
                }
            }

            // Token: 0x17000150 RID: 336
            public override JSONNode this[int aIndex]
            {
                get
                {
                    if (aIndex < 0 || aIndex >= this.m_List.Count)
                    {
                        return new JSONLazyCreator(this);
                    }
                    return this.m_List[aIndex];
                }
                set
                {
                    if (value == null)
                    {
                        value = new JSONNull();
                    }
                    if (aIndex < 0 || aIndex >= this.m_List.Count)
                    {
                        this.m_List.Add(value);
                    }
                    else
                    {
                        this.m_List[aIndex] = value;
                    }
                }
            }

            // Token: 0x17000151 RID: 337
            public override JSONNode this[string aKey]
            {
                get
                {
                    return new JSONLazyCreator(this);
                }
                set
                {
                    if (value == null)
                    {
                        value = new JSONNull();
                    }
                    this.m_List.Add(value);
                }
            }

            // Token: 0x17000152 RID: 338
            // (get) Token: 0x060009DD RID: 2525 RVA: 0x00042243 File Offset: 0x00040643
            public override int Count
            {
                get
                {
                    return this.m_List.Count;
                }
            }

            // Token: 0x060009DE RID: 2526 RVA: 0x00042250 File Offset: 0x00040650
            public override void Add(string aKey, JSONNode aItem)
            {
                if (aItem == null)
                {
                    aItem = new JSONNull();
                }
                this.m_List.Add(aItem);
            }

            // Token: 0x060009DF RID: 2527 RVA: 0x00042274 File Offset: 0x00040674
            public override JSONNode Remove(int aIndex)
            {
                if (aIndex < 0 || aIndex >= this.m_List.Count)
                {
                    return null;
                }
                JSONNode result = this.m_List[aIndex];
                this.m_List.RemoveAt(aIndex);
                return result;
            }

            // Token: 0x060009E0 RID: 2528 RVA: 0x000422B5 File Offset: 0x000406B5
            public override JSONNode Remove(JSONNode aNode)
            {
                this.m_List.Remove(aNode);
                return aNode;
            }

            // Token: 0x17000153 RID: 339
            // (get) Token: 0x060009E1 RID: 2529 RVA: 0x000422C8 File Offset: 0x000406C8
            public override IEnumerable<JSONNode> Children
            {
                get
                {
                    foreach (JSONNode N in this.m_List)
                    {
                        yield return N;
                    }
                    yield break;
                }
            }

            // Token: 0x060009E2 RID: 2530 RVA: 0x000422EC File Offset: 0x000406EC
            public IEnumerator GetEnumerator()
            {
                foreach (JSONNode N in this.m_List)
                {
                    yield return N;
                }
                yield break;
            }

            // Token: 0x060009E3 RID: 2531 RVA: 0x00042308 File Offset: 0x00040708
            public override void Serialize(System.IO.BinaryWriter aWriter)
            {
                aWriter.Write(1);
                aWriter.Write(this.m_List.Count);
                for (int i = 0; i < this.m_List.Count; i++)
                {
                    this.m_List[i].Serialize(aWriter);
                }
            }

            // Token: 0x060009E4 RID: 2532 RVA: 0x0004235C File Offset: 0x0004075C
            internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
            {
                aSB.Append('[');
                int count = this.m_List.Count;
                if (this.inline)
                {
                    aMode = JSONTextMode.Compact;
                }
                for (int i = 0; i < count; i++)
                {
                    if (i > 0)
                    {
                        aSB.Append(',');
                    }
                    if (aMode == JSONTextMode.Indent)
                    {
                        aSB.AppendLine();
                    }
                    if (aMode == JSONTextMode.Indent)
                    {
                        aSB.Append(' ', aIndent + aIndentInc);
                    }
                    this.m_List[i].WriteToStringBuilder(aSB, aIndent + aIndentInc, aIndentInc, aMode);
                }
                if (aMode == JSONTextMode.Indent)
                {
                    aSB.AppendLine().Append(' ', aIndent);
                }
                aSB.Append(']');
            }

            // Token: 0x040008B0 RID: 2224
            private List<JSONNode> m_List = new List<JSONNode>();

            // Token: 0x040008B1 RID: 2225
            public bool inline;
        }
        // Token: 0x02000136 RID: 310
        public static class JSON
        {
            // Token: 0x06000A3B RID: 2619 RVA: 0x00043475 File Offset: 0x00041875
            public static JSONNode Empty => JSON.Parse("{}");
            public static JSONNode Parse(string aJSON)
            {
                return JSONNode.Parse(aJSON);
            }
            public static string Format(string input, string Indent = "    ")
            {
                var output = new StringBuilder(input.Length * 2);
                char? quote = null;
                int depth = 0;

                for (int i = 0; i < input.Length; ++i)
                {
                    char ch = input[i];

                    switch (ch)
                    {
                        case '{':
                        case '[':
                            output.Append(ch);
                            if (!quote.HasValue)
                            {
                                output.AppendLine();
                                output.Append(Repeat(Indent, ++depth));
                            }
                            break;
                        case '}':
                        case ']':
                            if (quote.HasValue)
                                output.Append(ch);
                            else
                            {
                                output.AppendLine();
                                output.Append(Repeat(Indent, --depth));
                                output.Append(ch);
                            }
                            break;
                        case '"':
                        case '\'':
                            output.Append(ch);
                            if (quote.HasValue)
                            {
                                if (!IsEscaped(output, i))
                                    quote = null;
                            }
                            else quote = ch;
                            break;
                        case ',':
                            output.Append(ch);
                            if (!quote.HasValue)
                            {
                                output.AppendLine();
                                output.Append(Repeat(Indent, depth));
                            }
                            break;
                        case ':':
                            if (quote.HasValue) output.Append(ch);
                            else output.Append(" : ");
                            break;
                        default:
                            if (quote.HasValue || !char.IsWhiteSpace(ch))
                                output.Append(ch);
                            break;
                    }
                }

                return output.ToString();
            }
            private static string Repeat(string str, int count)
            {
                return new StringBuilder().Insert(0, str, count).ToString();
            }

            private static bool IsEscaped(string str, int index)
            {
                bool escaped = false;
                while (index > 0 && str[--index] == '\\') escaped = !escaped;
                return escaped;
            }

            private static bool IsEscaped(StringBuilder str, int index)
            {
                return IsEscaped(str.ToString(), index);
            }
        }
        internal static class Extensions
        {
            public static void ForEach<T>(this IEnumerable<T> ie, Action<T> action)
            {
                foreach (var i in ie)
                {
                    action(i);
                }
            }
        }
    }
}
