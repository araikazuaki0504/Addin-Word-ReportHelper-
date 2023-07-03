using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace makeTableFromExcel
{
    class CreateTableToWord
    {
        private List<List<object>> _TargetData;
        private string _filePath = string.Empty;

        public CreateTableToWord(string FilePath,ref List<List<object>> Data)
        {
            _TargetData = Data;
            _filePath = FilePath;
        }



    }
}
