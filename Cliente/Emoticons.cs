using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    public class Emoticons
    {
        private List<string> Emotes = new List<string>
        {
            "(◉ܫ◉)",
            "(ၜ︗ၜ )",
            "( ͡° ͜ʖ ͡°)",
            "ʕ•ᴥ•ʔ",
            "ಠ_ಠ",
            "(ಥ﹏ಥ)",
            "(ᵔᴥᵔ)",
            "ಠ╭╮ಠ",
            "♥‿♥",
            "(¬_¬)",
            "[̲̅$̲̅(̲̅5̲̅)̲̅$̲̅]",
            "(ง'̀-'́)ง",
            "(/) (°,,°) (/)"
        };

        public string getEmoticon(int id)
        {
            return Emotes[id];
        }

    }
}
