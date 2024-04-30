using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.CONSTdata
{
    public static class CONST
    {
        public static readonly Dictionary<char, char> VIETNAMDICT = new Dictionary<char, char>()
{
    {'á', 'a'}, {'à', 'a'}, {'ả', 'a'}, {'ã', 'a'}, {'ạ', 'a'},
    {'â', 'a'}, {'ấ', 'a'}, {'ầ', 'a'}, {'ẩ', 'a'}, {'ẫ', 'a'},
    {'é', 'e'}, {'è', 'e'}, {'ẻ', 'e'}, {'ẽ', 'e'}, {'ẹ', 'e'},
    {'ê', 'e'}, {'ế', 'e'}, {'ề', 'e'}, {'ể', 'e'}, {'ễ', 'e'},
    {'ó', 'o'}, {'ò', 'o'}, {'ỏ', 'o'}, {'õ', 'o'}, {'ọ', 'o'},
    {'ô', 'o'}, {'ố', 'o'}, {'ồ', 'o'}, {'ổ', 'o'}, {'ỗ', 'o'},
    {'ú', 'u'}, {'ù', 'u'}, {'ủ', 'u'}, {'ũ', 'u'}, {'ụ', 'u'},
    {'ư', 'u'}, {'ứ', 'u'}, {'ừ', 'u'}, {'ử', 'u'}, {'ữ', 'u'},
    {'í', 'i'}, {'ì', 'i'}, {'ỉ', 'i'}, {'ĩ', 'i'}, {'ị', 'i'},
    {'ý', 'y'}, {'ỳ', 'y'}, {'ỷ', 'y'}, {'ỹ', 'y'}, {'ỵ', 'y'},
    {'đ', 'd'}, {'Đ', 'D'}
};
        public static readonly Dictionary<char, char> VietnameseAccentMapping =
                new Dictionary<char, char>()
                {
            { 'À', 'A' }, { 'Á', 'A' }, { 'Ạ', 'A' }, { 'Ả', 'A' }, { 'Ã', 'A' }, { 'Â', 'A' },
            { 'Ấ', 'A' }, { 'Ầ', 'A' }, { 'Ậ', 'A' }, { 'Ẩ', 'A' }, { 'Ẫ', 'A' }, { 'Ă', 'A' },
            { 'Ắ', 'A' }, { 'Ằ', 'A' }, { 'Ặ', 'A' }, { 'Ẳ', 'A' }, { 'Ẵ', 'A' },
            { 'È', 'E' }, { 'É', 'E' }, { 'Ẹ', 'E' }, { 'Ẻ', 'E' }, { 'Ẽ', 'E' }, { 'Ê', 'E' },
            { 'Ế', 'E' }, { 'Ề', 'E' }, { 'Ệ', 'E' }, { 'Ể', 'E' }, { 'Ễ', 'E' },
            { 'Ì', 'I' }, { 'Í', 'I' }, { 'Ị', 'I' }, { 'Ỉ', 'I' }, { 'Ĩ', 'I' },
            { 'Ò', 'O' }, { 'Ó', 'O' }, { 'Ọ', 'O' }, { 'Ỏ', 'O' }, { 'Õ', 'O' }, { 'Ô', 'O' },
            { 'Ố', 'O' }, { 'Ồ', 'O' }, { 'Ộ', 'O' }, { 'Ổ', 'O' }, { 'Ỗ', 'O' },
            { 'Ù', 'U' }, { 'Ú', 'U' }, { 'Ụ', 'U' }, { 'Ủ', 'U' }, { 'Ũ', 'U' }, { 'Ư', 'U' },
            { 'Ứ', 'U' }, { 'Ừ', 'U' }, { 'Ự', 'U' }, { 'Ử', 'U' }, { 'Ữ', 'U' },
            { 'Ỳ', 'Y' }, { 'Ý', 'Y' }, { 'Ỵ', 'Y' }, { 'Ỷ', 'Y' }, { 'Ỹ', 'Y' },
            { 'Đ', 'D' }
                };
        public static string DOWNLOADS = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";

        public static string RemoveSigns(string text)
        {
            string[] signs = new string[] { "aAeEoOuUiIdDyY",
        "áàạảãâấầậẩẫăắằặẳẵ",
        "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
        "éèẹẻẽêếềệểễ",
        "ÉÈẸẺẼÊẾỀỆỂỄ",
        "óòọỏõôốồộổỗơớờợởỡ", 
        "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
        "úùụủũưứừựửữ",
        "ÚÙỤỦŨƯỨỪỰỬỮ",
        "íìịỉĩ",
        "ÍÌỊỈĨ",
        "đ",
        "Đ",
        "ýỳỵỷỹ",
        "ÝỲỴỶỸ" };

            for (int i = 1; i < signs.Length; i++)
            {
                for (int j = 0; j < signs[i].Length; j++)
                    text = text.Replace(signs[i][j], signs[0][i - 1]);
            }
            return text;
        }

    }



}
