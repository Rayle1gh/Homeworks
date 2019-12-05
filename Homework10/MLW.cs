using System.Collections.Generic;

namespace Homework10
{
    class MultipleLogWriter : AbstractLogWriter
    {

        private List<AbstractLogWriter> _list;
        public MultipleLogWriter(List<AbstractLogWriter> list)
        {
            _list = list;
        }
        public override void LogWriting(string message)
        {
            foreach (AbstractLogWriter a in _list)
            {
                a.LogWriting(message);
            }
        }
    }
}
