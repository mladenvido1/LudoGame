﻿using System;
namespace ITD.OOP1.Ludo
{
    public enum TokenState { Home, InPlay, Safe };
    
    public class Token
    {
        private int tokenId;
        private GameColor color;
        private TokenState state;

        // Constructor
        public Token(int id, GameColor clr)
        {
            this.tokenId = id;
            this.color = clr;
            this.state = TokenState.Home;
        }

		public int GetTokenId()
		{
            return this.tokenId;
		}

        public GameColor GetColor()
        {
            return this.color;
        }

        public TokenState GetState()
		{
            return this.state;
		}
    }
}
