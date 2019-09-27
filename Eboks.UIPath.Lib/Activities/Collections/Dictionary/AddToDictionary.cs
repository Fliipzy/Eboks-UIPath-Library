using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;
using System.ComponentModel;

namespace Eboks.UIPath.Lib.Activities.Collections.Dictionary
{
    [DisplayName("Add to dictionary"), DesignerCategory("Collections")]
    [Description("Adds a KeyValuePair to a dictionary.")]
    public class AddToDictionary<T,U> : CodeActivity
    {
        [Category("Input"), DisplayName("Dictionary Target"), RequiredArgument]
        [Description("The target dictionary, which the KeyValuePair will be added to.")]
        public InArgument<Dictionary<T, U>> Dictionary { get; set; }

        [Category("Input"), RequiredArgument]
        [Description("The key object, to be added.")]
        public InArgument<T> Key { get; set; }

        [Category("Input"), RequiredArgument]
        [Description("The value object, to be added.")]
        public InArgument<U> Value { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            var key = Key.Get(context);
            var value = Value.Get(context);
            Dictionary.Get(context).Add(key, value);
        }
    }
}
