using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfIntroOvl3
{
    public class MessageClass
    {
        public string MsgItem { get; set; }
        public string AnsOne { get; set; }
        public string AnsTwo { get; set; }
        public MessageClass(MessageClass MsgClass) : this(MsgClass.MsgItem, MsgClass.AnsOne, MsgClass.AnsTwo) { }
        public MessageClass(string msgItem, string ansOne, string ansTwo) 
        {
            MsgItem = msgItem;
            AnsOne = ansOne;
            AnsTwo = ansTwo;
        }
    }
}
