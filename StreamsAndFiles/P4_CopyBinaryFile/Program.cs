using System.IO;

namespace P4_CopyBinaryFile
{
    class Program
    {
        static void Main()
        {

            var sourceFile = new FileStream("myPicture.jpg", FileMode.Open);
            var targetFile = new FileStream("CopiedmyPicture.jpg", FileMode.Create);

            using (sourceFile)
            {
                using (targetFile)
                {
                    while (sourceFile.Position < sourceFile.Length)
                    {
                        targetFile.WriteByte((byte)sourceFile.ReadByte());
                    }
                }
            }
        }
    }
}
