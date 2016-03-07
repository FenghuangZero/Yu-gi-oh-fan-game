﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGOCardGame
{
    public class Card
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int Number { get; set; }
        public string Type { get; set; }

        public Card()
        {
            Name = "";
            Image = "";
            Description = "";
            Number = 0;
            Type = "";
        }
        public Card(string cardName, string cardDesc, int cardNum, string cardType)
        {
            this.Name = cardName;
            Image = "";
            this.Description = cardDesc;
            this.Number = cardNum;
            this.Type = cardType;
        }
    }

    public class MonsterCard : Card
    {
        public string Attribute { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int Level { get; set; }

        public MonsterCard()
        {
            Attribute = "";
            Attack = 0;
            Defence = 0;
            Level = 0;
        }

        public MonsterCard(string cardName, string cardDesc, int cardNum, string cardType, string cardAttribute, int cardAttack, int cardDefence, int cardLevel)
        {
            this.Name = cardName;
            Image = "";
            this.Description = cardDesc;
            this.Number = cardNum;
            this.Type = cardType;
            this.Attribute = cardAttribute;
            this.Attack = cardAttack;
            this.Defence = cardDefence;
            this.Level = cardLevel;
        }
    }

    public class SpellCard : Card
    {
        public string Property { get; set; }
        public string Effect { get; set; }

        public SpellCard()
        {
            Property = "";
            Effect = "";
        }

        public SpellCard(string cardName, string cardDesc, int cardNum, string cardType, string cardProp, string cardEffect)
        {
            this.Name = cardName;
            Image = "";
            this.Description = cardDesc;
            this.Number = cardNum;
            this.Type = cardType;
            this.Property = cardProp;
            this.Effect = cardEffect;
        }
    }
}
