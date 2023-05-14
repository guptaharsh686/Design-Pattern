using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern
{
    public class History
    {
        private List<DocumentState> stateList = new List<DocumentState>();

        public void push(DocumentState state)
        {
            stateList.Add(state);
        }


        public DocumentState pop()
        {
            var state = stateList[stateList.Count - 1];
            stateList.Remove(state);
            return stateList[stateList.Count - 1];
        }
    }
}
