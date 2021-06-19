using Ntron.Models.TRC10Token;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ntron.Providers
{
    public interface ITRC10TokenProvider
    {
        TransferAsset.Response TransferAsset(TransferAsset.Request model);
    }
    public class TRC10TokenProvider : ITRC10TokenProvider
    {
        public TransferAsset.Response TransferAsset(TransferAsset.Request model)
        {
            throw new NotImplementedException();
        }
    }
}
