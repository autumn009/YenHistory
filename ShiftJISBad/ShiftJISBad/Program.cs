using System.Text;
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
const string target = @"c:\ビジネス文書\企画表.txt";
byte[] bytes = Encoding.GetEncoding("Shift_JIS").GetBytes(target);
int count  = 0;
for (int i = 0; i < bytes.Length; i++)
{
    if(bytes[i] == '\\') count++;
}
Console.WriteLine($"{target}のディレクトリ区切り記号の数は{count}個です。");
