using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;
using System.ComponentModel;

namespace Eboks.UIPath.Lib.Activities.Collections.Dictionary
{
    class AddToDictionary<T,U> : CodeActivity
    {
        [Category("Input")]
        [RequiredArgument]
        private InArgument<Dictionary<T, U>> Dictionary { get; set; }

        [Category("Input")]
        [RequiredArgument]
        private InArgument<T> Key { get; set; }

        [Category("Input")]
        [RequiredArgument]
        private InArgument<U> Value { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            var key = Key.Get(context);
            var value = Value.Get(context);
            Dictionary.Get(context).Add(key, value);
        }
    }
}
