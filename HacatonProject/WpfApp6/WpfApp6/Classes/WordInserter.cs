using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ВАЖНО в ссылках указать InteropWord (Object Library)
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Windows;
using static WpfApp6.Classes.ClassHelper;

namespace WpfApp6.Classes
{
    public class WordInserter
    {
        private FileInfo _fileInfo;

        public WordInserter(string filepath)
        {
            if (File.Exists(filepath))
            {
                _fileInfo = new FileInfo(filepath);
            }
            else
            {
                throw new ArgumentException("Файл не найден");
            }
        }

        internal bool Process(Dictionary<string, string> items, string[] students)
        {
            Word.Application app = null;
            try
            {
                app = new Word.Application();
                Object file = _fileInfo.FullName;
                Object missing = Type.Missing;

                app.Documents.Open(file);

                foreach (var item in items)
                {
                    Word.Find find = app.Selection.Find;
                    find.Text = item.Key;
                    find.Replacement.Text = item.Value;

                    Object wrap = Word.WdFindWrap.wdFindContinue;
                    Object replace = Word.WdReplace.wdReplaceAll;

                    find.Execute(
                        FindText: Type.Missing,
                        MatchCase: false,
                        MatchWholeWord: false,
                        MatchWildcards: false,
                        MatchSoundsLike: missing,
                        MatchAllWordForms: false,
                        Forward: true,
                        Wrap: wrap,
                        Format: false,
                        ReplaceWith: missing, Replace: replace
                        );
                }

                for (int i = 0; i < 30; i++)
                {
                    if (i < students.Length)
                    {
                        string i1 = (i + 1).ToString();
                        Word.Find find = app.Selection.Find;

                        find.Text = "<Student" + i1 + "_NUM>";
                        find.Replacement.Text = i1;

                        Object wrap = Word.WdFindWrap.wdFindContinue;
                        Object replace = Word.WdReplace.wdReplaceAll;

                        find.Execute(
                            FindText: Type.Missing,
                            MatchCase: false,
                            MatchWholeWord: false,
                            MatchWildcards: false,
                            MatchSoundsLike: missing,
                            MatchAllWordForms: false,
                            Forward: true,
                            Wrap: wrap,
                            Format: false,
                            ReplaceWith: missing, Replace: replace
                            );

                        find.Text = "<Student" + i1 + "_FIO>";
                        find.Replacement.Text = students[i];

                        find.Execute(
                            FindText: Type.Missing,
                            MatchCase: false,
                            MatchWholeWord: false,
                            MatchWildcards: false,
                            MatchSoundsLike: missing,
                            MatchAllWordForms: false,
                            Forward: true,
                            Wrap: wrap,
                            Format: false,
                            ReplaceWith: missing, Replace: replace
                            );
                    }
                    else
                    {
                        string i1 = (i + 1).ToString();
                        Word.Find find = app.Selection.Find;

                        find.Text = "<Student" + i1 + "_NUM>";
                        find.Replacement.Text = "";

                        Object wrap = Word.WdFindWrap.wdFindContinue;
                        Object replace = Word.WdReplace.wdReplaceAll;

                        find.Execute(
                            FindText: Type.Missing,
                            MatchCase: false,
                            MatchWholeWord: false,
                            MatchWildcards: false,
                            MatchSoundsLike: missing,
                            MatchAllWordForms: false,
                            Forward: true,
                            Wrap: wrap,
                            Format: false,
                            ReplaceWith: missing, Replace: replace
                            );

                        find.Text = "<Student" + i1 + "_FIO>";
                        find.Replacement.Text = "";

                        find.Execute(
                            FindText: Type.Missing,
                            MatchCase: false,
                            MatchWholeWord: false,
                            MatchWildcards: false,
                            MatchSoundsLike: missing,
                            MatchAllWordForms: false,
                            Forward: true,
                            Wrap: wrap,
                            Format: false,
                            ReplaceWith: missing, Replace: replace
                            );
                    }
                }

                Object newFileName = Path.Combine(FolderVedomostFilePath, DateTime.Now.ToString("dd.MM.yyyy hh-mm-ss")+"_" + _fileInfo.Name);
                app.ActiveDocument.SaveAs2(newFileName);
                app.ActiveDocument.Close();
                MessageBox.Show("Ведомость создана");
                return true;
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
                if (app != null) { app.Quit(); };
            };
            return false;
        }
    }
}
