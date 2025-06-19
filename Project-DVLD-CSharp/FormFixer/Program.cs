//using System;
//using System.IO;
//using System.Text.RegularExpressions;

//namespace FormFixer
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string projectFolder = @"C:\Users\LENOVO\source\repos\project19";
//            string backupFolder = Path.Combine(projectFolder, "FormFixerBackup");

//            // إنشاء مجلد النسخ الاحتياطي إذا لم يكن موجودًا
//            Directory.CreateDirectory(backupFolder);

//            var csFiles = Directory.GetFiles(projectFolder, "*.cs", SearchOption.AllDirectories);
//            int modifiedCount = 0;

//            foreach (var file in csFiles)
//            {
//                string content = File.ReadAllText(file);

//                // نبحث عن أي كلاس يرث من Form
//                if (Regex.IsMatch(content, @"public\s+partial\s+class\s+\w+\s*:\s*Form\b"))
//                {
//                    // نسخ احتياطي للملف الأصلي
//                    string relativePath = Path.GetRelativePath(projectFolder, file);
//                    string backupPath = Path.Combine(backupFolder, relativePath);
//                    Directory.CreateDirectory(Path.GetDirectoryName(backupPath)!);
//                    File.Copy(file, backupPath, true);

//                    // التعديل
//                    string newContent = Regex.Replace(content, @"(public\s+partial\s+class\s+\w+\s*:\s*)Form\b", "$1frmBase");
//                    File.WriteAllText(file, newContent);

//                    Console.WriteLine("✔ تم التعديل والنسخ الاحتياطي: " + relativePath);
//                    modifiedCount++;
//                }
//            }

//            Console.WriteLine($"\n✅ تم تعديل {modifiedCount} فورم، وتم حفظ النسخ الاحتياطية في:\n{backupFolder}");
//        }
//    }
//}
