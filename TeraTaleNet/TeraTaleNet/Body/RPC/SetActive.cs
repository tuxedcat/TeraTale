﻿namespace TeraTaleNet
{
    public class SetActive : RPC
    {
        public bool value;
        public SetActive(bool value)
            : base(RPCType.All)
        {
            this.value = value;
        }

        public SetActive()
            : base(RPCType.All)
        { }
    }
}