using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAPP.Shared.Exceptions.DataManagerExceptions
{
    public class PrimaryKeyAlreadyExistsException<TColumn> : ContainsKeyAndValueBaseException<TColumn>
    {
        public PrimaryKeyAlreadyExistsException(TColumn colValue, string colName) : base(colValue, colName) { }

        public PrimaryKeyAlreadyExistsException(TColumn colValue, string colName, string message) : base(colValue, colName, message) { }
    }
}
