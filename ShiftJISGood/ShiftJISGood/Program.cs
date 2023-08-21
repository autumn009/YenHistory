using System.Text;
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
const string target = @"c:\ビジネス文書\企画表.txt";
byte[] bytes = Encoding.GetEncoding("Shift_JIS").GetBytes(target);
int count = 0;
int pointer = 0;
for (; ; )
{
    if (IsDBCSLeadByte(bytes[pointer]))
        pointer += 2;
    else
    {
        if (bytes[pointer] == '\\') count++;
        pointer += 1;
    }
    if (pointer >= bytes.Length) break;
}
Console.WriteLine($"{target}のディレクトリ区切り記号の数は{count}個です。");

bool IsDBCSLeadByte(byte ch)
{
    return (ch >= 0x81 && ch <= 0x9f) || (ch >= 0xe0 && ch <= 0xef);
}