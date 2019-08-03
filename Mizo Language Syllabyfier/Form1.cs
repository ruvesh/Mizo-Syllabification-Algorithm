using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mizo_Language_Syllabyfier
{
    public partial class MizoSyllabifier : Form
    {
        private readonly SynchronizationContext sync;
        private DateTime dt = DateTime.Now;

        public MizoSyllabifier()
        {
            InitializeComponent();
            sync = SynchronizationContext.Current;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void load_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog();
            openFile.Title = "Browse";
            openFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFile.FileName, FileMode.Open);
                Byte[] b = new Byte[1024];
                UTF8Encoding temp = new UTF8Encoding();
                enter_text.Text = "";
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    enter_text.Text = enter_text.Text + temp.GetString(b);
                }
                fs.Close();
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            string text = Syllable.Text.ToString();
            var saveFile = new SaveFileDialog();
            saveFile.InitialDirectory = @"E:\";
            saveFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFile.FilterIndex = 1;
            saveFile.RestoreDirectory = true;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetFullPath(saveFile.FileName);
                File.AppendAllText(path, text);
                MessageBox.Show("Text saved to file " + path, "Save Successful");
            }
            else
            {
                MessageBox.Show("Error in Saving File", "Save Error!");
            }
        }

        private static bool isVowel(string word, int index)
        {
            bool ret = false;
            switch (word[index])
            {
                case 'A':
                case 'a':

                case 'E':
                case 'e':

                case 'I':
                case 'i':

                case 'U':
                case 'u':

                    ret = true;
                    break;

                default:
                    ret = false;
                    break;
            }

            return ret;
        }

        private async void  syllabify_button_Click(object sender, EventArgs e)
        {
            await Task.Run(() => {
                syllabifier_method();

            } );
           
        }

        private void syllabifier_method()
        {
            string enterredText = enter_text.Text.ToString();
            List<string> words = enterredText.Replace(",", "").Replace(".", "").Replace(":", "").Split(' ').ToList();
            int i = 0;
            this.Invoke((MethodInvoker)delegate ()

            {
                Syllable.Text = "";

                foreach (string word in words)
                {
                    for (i = 0; i < word.Length; i++)
                    {
                        Syllable.Text = Syllable.Text + word[i].ToString();
                        
                        if (i + 5 <= word.Length - 1)
                        {
                            if (isVowel(word, i))
                            {
                                if (word[i+1].Equals('\u0302') || word[i+1].Equals('\u030c'))
                                {
                                    if (word[i + 2].Equals('w') || word[i + 2].Equals('W'))
                                    {
                                        Syllable.Text += word[i + 1].ToString();
                                        Syllable.Text += word[i + 2].ToString();
                                        if(!isVowel(word, i+3))
                                            Syllable.Text += word[i + 3].ToString();
                                        Syllable.Text += ",";
                                        i += 3;
                                    }
                                    else
                                    {
                                        Syllable.Text += word[i + 1].ToString();
                                        Syllable.Text += word[i + 2].ToString();
                                        Syllable.Text += ",";
                                        i += 2;
                                    }
                                    
                                }
                            }
                            else if((!isVowel(word, i) && isVowel(word, i + 1) && (word[i + 2].Equals('\u0302') || word[i + 2].Equals('\u030c'))))
                            {
                                if (word[i + 3].Equals('w') || word[i + 3].Equals('W'))
                                {
                                    if (word[i + 4].Equals('n') || word[i + 4].Equals('N'))
                                    {
                                        if (word[i + 5].Equals('G') || word[i + 5].Equals('g'))
                                        {
                                            Syllable.Text += word[i + 1].ToString();
                                            Syllable.Text += word[i + 2].ToString();
                                            Syllable.Text += word[i + 3].ToString();
                                            Syllable.Text += word[i + 4].ToString();
                                            Syllable.Text += word[i + 5].ToString();
                                            Syllable.Text += ",";
                                            i += 5;
                                        }
                                    }
                                    else
                                    {
                                        Syllable.Text += word[i + 1].ToString();
                                        Syllable.Text += word[i + 2].ToString();
                                        Syllable.Text += word[i + 3].ToString();
                                        if (!isVowel(word, i + 4))
                                            Syllable.Text += word[i + 4].ToString();
                                        Syllable.Text += ",";
                                        i += 4;
                                    }
                                }
                                else if (!isVowel(word, i + 3))
                                {
                                    Syllable.Text += word[i + 1].ToString();
                                    Syllable.Text += word[i + 2].ToString();
                                    Syllable.Text += word[i + 3].ToString();
                                    Syllable.Text += ",";
                                    i += 3;
                                }
                                
                            }
                            else if ((!isVowel(word, i) && isVowel(word, i + 1) && !isVowel(word, i + 1 + 1)))
                            {

                                if (word[i + 1 + 1].Equals('W') || word[i + 1 + 1].Equals('w'))
                                {
                                    if (!isVowel(word, i + 1 + 1 + 1))
                                    {
                                        Syllable.Text += word[i + 1].ToString();
                                        Syllable.Text += word[i + 2].ToString();
                                        Syllable.Text += word[i + 3].ToString();
                                        Syllable.Text += ",";
                                        i += 3;
                                    }
                                }
                                else if (word[i + 1 + 1 + 1].Equals('G') || word[i + 1 + 1 + 1].Equals('g'))
                                {
                                    Syllable.Text += word[i + 1].ToString();
                                    Syllable.Text += word[i + 2].ToString();
                                    Syllable.Text += word[i + 3].ToString();
                                    Syllable.Text += ",";
                                    i += 3;
                                }
                                else
                                {
                                    Syllable.Text += word[i + 1].ToString();
                                    Syllable.Text += word[i + 2].ToString();
                                    Syllable.Text += ",";
                                    i += 2;
                                }
                            }
                            else if ((word[i].Equals('A') || word[i].Equals('a')) && (word[i + 1].Equals('W') || word[i + 1].Equals('w')) && !isVowel(word, i + 1 + 1))
                            {
                                Syllable.Text += word[i + 1].ToString();
                                Syllable.Text += word[i + 2].ToString();
                                Syllable.Text += ",";
                                i += 2;
                            }

                            else if ((word[i].Equals('N') || word[i].Equals('n')) && (word[i + 1].Equals('g') || word[i + 1].Equals('G')))
                            {
                                if (!isVowel(word, i + 1 + 1))
                                {
                                    Syllable.Text += word[i + 1].ToString();
                                    Syllable.Text += ",";

                                }
                                else
                                {
                                    Syllable.Text += word[i + 1].ToString();

                                }
                                i++;
                            }
                            else if ((word[i].Equals('C') || word[i].Equals('c')) && (word[i + 1].Equals('h') || word[i + 1].Equals('H')))
                            {
                                if (!isVowel(word, i + 1 + 1))
                                {
                                    Syllable.Text += word[i + 1].ToString();
                                    Syllable.Text += ",";

                                }
                                else
                                {
                                    Syllable.Text += word[i + 1].ToString();

                                }
                                i++;
                            }
                            else if (!isVowel(word, i) && !isVowel(word, i + 1))
                            {
                                Syllable.Text += ",";

                            }
                            else if ((isVowel(word, i) && isVowel(word, i + 1)) && (word[i] != word[i + 1]))
                            {
                                Syllable.Text += ",";

                            }

                            else if ((!isVowel(word, i) && isVowel(word, i + 1)) || (isVowel(word, i) && !isVowel(word, i + 1)))
                            {
                                if (word[i + 1 + 1] == 'g' || word[i + 1 + 1] == 'G')
                                {
                                    Syllable.Text += word[i + 1].ToString();
                                    Syllable.Text += word[i + 2].ToString();
                                    Syllable.Text += ",";
                                    i += 2;
                                }
                                else
                                {
                                    Syllable.Text += word[i + 1].ToString();
                                    Syllable.Text += ",";
                                    i++;
                                }

                            }
                        }
                        else
                            continue;
                    }
                    Syllable.AppendText(Environment.NewLine);
                }
            });
        }

        private void MizoSyllabifier_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure to Exit?", "Exit?", MessageBoxButtons.YesNo);
            if(res == DialogResult.No)
            {
                e.Cancel = true;
            }
           
        }
    }
}

