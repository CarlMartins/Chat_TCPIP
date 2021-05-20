﻿using System.Collections.Generic;

namespace Cliente
{
    public class Emoticons
    {
        private readonly List<string> _emotes = new List<string>
        {
            "♻",
            "🎄",
            "🌲",
            "🌳",
            "🌴",
            "🍃",
            "🌿",
            "☘",
            "🐤",
            "🐳",
            "🍆",
            "🌶",
            "🎤",
            "🌍",
            "💩",
            "🤣",
            "🤩",
            "😂",
            "😍",
            "😡",
            "😎",
            "😨",
            "😐",
            "😓",
            "😩",
            "💀",
            "🌤",
            "💧",
            "☔",
            "🌹",
            "🌺",
            "🚗",
            "✈",
            "❌",
            "⭕",
            "💯",
            "🚫",
            "🇧🇷",
            "✅",
            "🙏",
            "🤚",
            "🤝",
            "👌",
            "🖕",
            "👋",
            "💝",
        };

        public List<string> Emotes
        {
            get { return _emotes; }
            private set { }
        }
    }
}
