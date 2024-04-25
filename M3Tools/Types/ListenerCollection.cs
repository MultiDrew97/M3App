using System;

namespace SPPBC.M3Tools.Types
{
    public class ListenerCollection : DBEntryCollection<Listener>
    {

        public override bool ApplyFilter(Listener listener, int index)
        {
			if (listener == null)
			{
				return false;
			}

            return listener.Name.Contains(Filter) || listener.Email.Contains(Filter);
        }
    }
}
