using System;
using CSharpExtendedCommands.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CSharpExtendedCommands.IO;
using System.Diagnostics;
using CSharpExtendedCommands.Data.SimpleJSON;
using static CSharpExtendedCommands.Maths;
using CSharpExtendedCommands.DataTypeExtensions;
using System.IO;
using CSharpExtendedCommands.DataTypeExtensions.RegularExpressions;
using System.Text.RegularExpressions;
using CSharpExtendedCommands.Web;
using CSharpExtendedCommands;
using System.Threading;
using CSharpExtendedCommands.DataTypeExtensions.UI;
using System.Reflection;

namespace FormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        static private string CalCheckSum(byte initial, byte[] _PacketData, int PacketLength)
        {
            Byte _CheckSumByte = initial;
            for (int i = 0; i < PacketLength; i++)
                _CheckSumByte ^= _PacketData[i];
            return Converter.DecimalToHexadecimal(int.Parse(_CheckSumByte.ToString()));
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var key = ComputerRegistry.OpenKey("HKCR\\*\\shell\\Notepad++");
            var root = ComputerRegistry.GetRootKey(key);
            MessageBox.Show(key.ToString() + "\n" + root.ToString());
            //MessageBox.Show();
            // var data = "691C6910AE47A7596DF3CB62331806F1691C6910AE47A7596DF3CB62981A000000000000000000000000000000000000000000003930333996E396EF51B858A6920C349DCCE7F90E96E396EF51B858A6920C349D67E500C6CFCCC6000000B0904F50454C00E4000000000000000000FFFFFFFFFFFFFF52454D4F464552FFFFFFFFFFFF0023000000";
        }
        public static int Checksum(string[] data)
        {
            int res = 1;
            for (int i = 0; i < data.Length; i++)
            {
                var cb = Converter.HexadecimalToDecimal(data[i]);
                res += cb;
            }
            return res;
        }
        void PrintObject(WorldObject @object)
        {
            label6.Text = "Object Name: " + @object.Name;
            label5.Text = "Object Mass: " + @object.Mass.ToString();
            label4.Text = "Object Volume: " + @object.Volume.ToString();
            label3.Text = "Object Density: " + @object.Density.ToString();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            WorldObject obj = new WorldObject("Quartz", 3.6);
            obj.Density = 2.65;
            PrintObject(obj);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //MyObject[] objects = new MyObject[2] { new MyObject("Primary Object", "First object data", 1, 22453), new MyObject("Divine Object", "Second object data", 24, 5523) };
            //var ser = new CSharpExtendedCommands.Data.JSONSerializer(typeof(MyObject[]));
            var json = "[{\"_id\": \"5d01909522356a603682d323\",\"index\": 0,\"guid\": \"24e06e95-87d1-4f10-8721-77457426aa5a\",\"isActive\": true,\"balance\": \"$2,294.12\",\"picture\": \"http://placehold.it/32x32\",\"age\": 24,\"eyeColor\": \"brown\",\"name\": \"Waters Nash\",\"gender\": \"male\",\"company\": \"JETSILK\",\"email\": \"watersnash@jetsilk.com\",\"phone\": \"+1 (802) 404-3086\",\"address\": \"662 Riverdale Avenue, Walland, Vermont, 9836\",\"about\": \"Proident minim id reprehenderit quis laboris deserunt dolore exercitation sit culpa proident. Ipsum labore et exercitation velit cillum ex. Veniam amet velit qui aute. Aute id ullamco labore voluptate. Laborum fugiat exercitation est nisi duis aliqua in id qui eu. Eu amet sint nisi amet id cillum irure laboris eu.\",\"registered\": \"2014-09-06T04:57:26 +03:00\",\"latitude\": -39.974913,\"longitude\": 124.939474,\"tags\": [\"exercitation\",\"ullamco\",\"minim\",\"sint\",\"sint\",\"ad\",\"velit\"],\"friends\": [{\"id\": 0,\"name\": \"Sharpe Moss\"},{\"id\": 1,\"name\": \"Acosta Noble\"},{\"id\": 2,\"name\": \"Potter Hess\"}],\"greeting\": \"Hello, Waters Nash! You have 3 unread messages.\",\"favoriteFruit\": \"strawberry\"},{\"_id\": \"5d019095eca766ecb05344b5\",\"index\": 1,\"guid\": \"bfa63a68-5a93-43f1-b4f4-03361625451b\",\"isActive\": false,\"balance\": \"$3,947.98\",\"picture\": \"http://placehold.it/32x32\",\"age\": 22,\"eyeColor\": \"brown\",\"name\": \"Nicholson Ashley\",\"gender\": \"male\",\"company\": \"COMTOURS\",\"email\": \"nicholsonashley@comtours.com\",\"phone\": \"+1 (952) 456-2637\",\"address\": \"458 Ash Street, Davenport, Virginia, 9887\",\"about\": \"Mollit dolore velit nisi deserunt Lorem et exercitation Lorem velit nostrud consectetur. Ut incididunt dolor magna consectetur pariatur amet deserunt occaecat aliquip minim. Quis sunt in tempor mollit labore fugiat occaecat. Aute ipsum proident aute ex excepteur nisi.\r\",\"registered\": \"2014-01-06T10:09:56 +02:00\",\"latitude\": 53.328441,\"longitude\": -88.482448,\"tags\": [\"non\",\"voluptate\",\"reprehenderit\",\"nostrud\",\"consequat\",\"laborum\",\"occaecat\"],\"friends\": [{\"id\": 0,\"name\": \"Small Grant\"},{\"id\": 1,\"name\": \"June Webster\"},{\"id\": 2,\"name\": \"Lynn Huffman\"}],\"greeting\": \"Hello, Nicholson Ashley! You have 2 unread messages.\",\"favoriteFruit\": \"apple\"},{\"_id\": \"5d0190951279a39dabc4d696\",\"index\": 2,\"guid\": \"5fd2a642-06d6-4981-8281-01a7408ae3e5\",\"isActive\": true,\"balance\": \"$3,345.98\",\"picture\": \"http://placehold.it/32x32\",\"age\": 27,\"eyeColor\": \"blue\",\"name\": \"Higgins Grimes\",\"gender\": \"male\",\"company\": \"SIGNITY\",\"email\": \"higginsgrimes@signity.com\",\"phone\": \"+1 (919) 578-2287\",\"address\": \"755 Little Street, Klagetoh, Wyoming, 7528\",\"about\": \"Duis eiusmod exercitation commodo magna deserunt qui esse exercitation sit sit pariatur reprehenderit. Aliqua et irure tempor tempor minim laboris consequat ea. Nulla cillum et laboris Lorem laboris occaecat do do cillum et incididunt commodo eu. Sit amet ad laborum mollit labore.\r\",\"registered\": \"2015-01-26T04:52:26 +02:00\",\"latitude\": 27.533799,\"longitude\": 11.862106,\"tags\": [\"eiusmod\",\"aliqua\",\"duis\",\"proident\",\"nostrud\",\"veniam\",\"qui\"],\"friends\": [{\"id\": 0,\"name\": \"Noemi Dalton\"},{\"id\": 1,\"name\": \"Clarice Bray\"},{\"id\": 2,\"name\": \"Lancaster Tanner\"}],\"greeting\": \"Hello, Higgins Grimes! You have 1 unread messages.\",\"favoriteFruit\": \"strawberry\"},{\"_id\": \"5d019095cc3b4f2104ff4ef3\",\"index\": 3,\"guid\": \"27da7b8f-89c5-49dc-b1ae-8c7fb99db278\",\"isActive\": false,\"balance\": \"$3,694.48\",\"picture\": \"http://placehold.it/32x32\",\"age\": 21,\"eyeColor\": \"green\",\"name\": \"Maynard Dickson\",\"gender\": \"male\",\"company\": \"ZIORE\",\"email\": \"maynarddickson@ziore.com\",\"phone\": \"+1 (977) 516-3339\",\"address\": \"471 Radde Place, Sultana, Delaware, 6974\",\"about\": \"Tempor voluptate ullamco aute esse minim aliquip fugiat ut duis dolore ad enim deserunt. Magna tempor qui nisi cillum aliqua exercitation velit ut non qui culpa nulla. Adipisicing adipisicing voluptate consectetur aliquip consectetur officia Lorem. Sit voluptate enim aliqua sit labore ex exercitation magna irure consectetur est ex eu.\r\",\"registered\": \"2014-07-31T01:14:22 +03:00\",\"latitude\": 81.676173,\"longitude\": -164.529024,\"tags\": [\"nisi\",\"ad\",\"voluptate\",\"aliqua\",\"adipisicing\",\"ea\",\"nulla\"],\"friends\": [{\"id\": 0,\"name\": \"Virgie Lester\"},{\"id\": 1,\"name\": \"Caroline Farmer\"},{\"id\": 2,\"name\": \"Bethany Atkinson\"}],\"greeting\": \"Hello, Maynard Dickson! You have 5 unread messages.\",\"favoriteFruit\": \"apple\"},{\"_id\": \"5d01909512a037685fab2853\",\"index\": 4,\"guid\": \"2215eba0-121f-4a0d-ba8c-c26cd46aae0f\",\"isActive\": true,\"balance\": \"$1,305.35\",\"picture\": \"http://placehold.it/32x32\",\"age\": 37,\"eyeColor\": \"brown\",\"name\": \"Naomi Saunders\",\"gender\": \"female\",\"company\": \"IPLAX\",\"email\": \"naomisaunders@iplax.com\",\"phone\": \"+1 (961) 485-3874\",\"address\": \"129 Lorraine Street, Chestnut, American Samoa, 6758\",\"about\": \"Sint laborum laboris enim culpa minim. Quis quis elit eu ullamco qui elit Lorem eu non adipisicing ullamco elit. Eu reprehenderit aliquip labore laboris ipsum ipsum elit laborum laborum aute eu. Culpa qui proident consequat aliqua enim cillum irure consequat eu deserunt occaecat.\r\",\"registered\": \"2016-05-20T08:37:57 +03:00\",\"latitude\": -75.846335,\"longitude\": 53.115066,\"tags\": [\"consectetur\",\"dolore\",\"deserunt\",\"incididunt\",\"sit\",\"et\",\"qui\"],\"friends\": [{\"id\": 0,\"name\": \"Meyers Levine\"},{\"id\": 1,\"name\": \"Anastasia Ayala\"},{\"id\": 2,\"name\": \"Mia Burt\"}],\"greeting\": \"Hello, Naomi Saunders! You have 1 unread messages.\",\"favoriteFruit\": \"banana\"},{\"_id\": \"5d019095119009385405f450\",\"index\": 5,\"guid\": \"d046c9a0-3f60-4c35-827c-d7b58d3a4e44\",\"isActive\": false,\"balance\": \"$3,604.53\",\"picture\": \"http://placehold.it/32x32\",\"age\": 27,\"eyeColor\": \"blue\",\"name\": \"Singleton Warren\",\"gender\": \"male\",\"company\": \"PORTALINE\",\"email\": \"singletonwarren@portaline.com\",\"phone\": \"+1 (834) 598-3749\",\"address\": \"573 Seba Avenue, Trona, Hawaii, 6152\",\"about\": \"Enim incididunt proident deserunt ipsum. Reprehenderit ut exercitation nostrud ut magna mollit. Cupidatat ea nulla proident sunt sint cillum ex qui deserunt enim.\r\",\"registered\": \"2019-05-17T12:53:39 +03:00\",\"latitude\": 18.560505,\"longitude\": 15.2552,\"tags\": [\"ullamco\",\"sit\",\"nostrud\",\"veniam\",\"Lorem\",\"amet\",\"consectetur\"],\"friends\": [{\"id\": 0,\"name\": \"Finch Acosta\"},{\"id\": 1,\"name\": \"Abby Oconnor\"},{\"id\": 2,\"name\": \"Haynes Holland\"}],\"greeting\": \"Hello, Singleton Warren! You have 9 unread messages.\",\"favoriteFruit\": \"apple\"},{\"_id\": \"5d019095bbebb084c9cb096c\",\"index\": 6,\"guid\": \"ad700c9d-2cbc-486c-8227-d21a9ec7b69f\",\"isActive\": true,\"balance\": \"$2,384.47\",\"picture\": \"http://placehold.it/32x32\",\"age\": 26,\"eyeColor\": \"brown\",\"name\": \"Ratliff Mercer\",\"gender\": \"male\",\"company\": \"MEDIOT\",\"email\": \"ratliffmercer@mediot.com\",\"phone\": \"+1 (908) 529-3299\",\"address\": \"396 Conduit Boulevard, Tryon, South Carolina, 175\",\"about\": \"Pariatur in do mollit voluptate non minim excepteur proident excepteur nostrud ut sit. Dolor dolore amet est irure consectetur eiusmod non incididunt duis. Ullamco ipsum dolore labore dolor deserunt exercitation sit in eiusmod qui. Eu exercitation esse cupidatat excepteur id tempor enim. Labore tempor proident nisi ipsum ut consectetur elit laboris aliquip. Veniam magna quis anim in cupidatat duis eiusmod proident occaecat dolore sit.\r\",\"registered\": \"2017-05-14T09:06:10 +03:00\",\"latitude\": 13.771167,\"longitude\": 157.080584,\"tags\": [\"reprehenderit\",\"adipisicing\",\"non\",\"est\",\"tempor\",\"id\",\"cillum\"],\"friends\": [{\"id\": 0,\"name\": \"Phyllis Simpson\"},{\"id\": 1,\"name\": \"Potts Wells\"},{\"id\": 2,\"name\": \"Rebekah Charles\"}],\"greeting\": \"Hello, Ratliff Mercer! You have 10 unread messages.\",\"favoriteFruit\": \"strawberry\"}]".Replace("\r", "");
            using (System.IO.StreamWriter wr = new System.IO.StreamWriter("dataRaw.json"))
                wr.Write(json);
            using (System.IO.StreamWriter wr = new System.IO.StreamWriter("data.json"))
                wr.Write(JSON.Format(json));
            //MessageBox.Show(CSharpExtendedCommands.Maths.Baskara(1, 1, -4, true).ToString());
        }
        public class MyObject
        {
            public MyObject(string _ObjectName, string data, int id, int index)
            {
                this._ObjectName = _ObjectName;
                Data = data;
                Id = id;
                Index = index;
            }

            public string _ObjectName { get; }
            public string Data { get; }
            public int Id { get; }
            public int Index { get; }
        }
        void AsyncTask()
        {
            var client = new CSharpExtendedCommands.Web.FTPClient("programs.freevar.com", "gustavogus", "programs.freevar.com@freetzi.com");
            var dir = client.GetDirectory("/projects");
            var dirinfo = new System.IO.DirectoryInfo(@"C:\Users\Gu\Desktop\Programs\.Projects\_ExtendedCommands.zip");
            dir.Download(@"C:\Users\Gu\Desktop\test");
            MessageBox.Show("Download Finished!", "Download", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            var s = "";
            foreach (var res in Resource.ListResources("FormApp", "Resources"))
                s += res + "\n";
            MessageBox.Show(s);
            //MessageBox.Show("Username: " + username.Groups[0].Value.Replace(username.Groups[1].Value, "").Replace(spliter, "") + ".\nPassword: " + password.Groups[0].Value.Replace(password.Groups[1].Value, "").Replace(spliter, "") + ".\nSession: " + session.Groups[0].Value.Replace(session.Groups[1].Value, "").Replace(spliter, "") + ".");
            //var t = new System.Threading.Thread(AsyncTask);
            //t.Start();
            //richTextBox1.Clear();
        }
        UserControl1 c = new UserControl1();
        private void Button5_Click(object sender, EventArgs e)
        {
            grid.ItemSize = new Size(32, 32);
            grid.AddItem(new Panel() { BackColor = Color.White });
            grid.AddItem(new Panel() { BackColor = Color.White });
            grid.AddItem(new Panel() { BackColor = Color.White });
            grid.AddItem(new Panel() { BackColor = Color.White });
            grid.AddItem(new Panel() { BackColor = Color.White });
        }

        private void C_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            sender.GetType().GetProperty("Width").SetValue(sender, 500, null);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.MouseEnter += h;
            panel1.MouseLeave += o;
        }
        void h(object sender, EventArgs e)
        {
            panel1.ChangeBGColorSmoothly(Color.Gray, 2);
            //new Thread(DoMeh).Start();
        }
        void o(object sender ,EventArgs e)
        {
            panel1.ChangeBGColorSmoothly(SystemColors.ActiveCaption, 2);
            //new Thread(DoMeo).Start();
        }
        void DoMeh()
        {  } 
        void DoMeo()
        { var clr = SystemColors.ActiveCaption;
           }
        private void UploadComplete(object sender, ProgressChangedEventArgs e)
        {
            MessageBox.Show("Upload complete!");
        }

        private void UploadProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label8.Text = progressBar1.GetPercentage().ToString() + "%";
            label9.Text = e.UserState.ToString();
            Application.DoEvents();
        }

        private void Copy_CopyComplete(object sender, ProgressChangedEventArgs e)
        {
            MessageBox.Show("Done");
        }

        private void Copy_CopyProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label8.Text = progressBar1.GetPercentage().ToString() + "%";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
    public class Obj
    {
        public Obj() { }
        public Obj(string value, int content)
        {
            Name = value;
            Content = content;
        }
        public new string ToString() => "Name : " + Name + "; Content : " + Content.ToString();
        public string Name { get; set; }
        public int Content { get; set; }
    }
}