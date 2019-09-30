using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;
using System.ComponentModel;

namespace Eboks.UIPath.Lib.Activities.Collections.Dictionary
{
    [DisplayName("Add to dictionary")]
    [Description("Adds a KeyValuePair to a dictionary.")]
    public sealed class AddToDictionary<TKey, TValue> : CodeActivity
    {
        [Category("Input")]
        [RequiredArgument]
        [DisplayName("Key type")]
        public Type KeyType { get; set; } = typeof(object);

        [Category("Input")]
        [RequiredArgument]
        [DisplayName("Value type")]
        public Type ValueType { get; set; } = typeof(object);

        [Category("Input")]
        [RequiredArgument]
        [DisplayName("Dictionary target")]
        [Description("The target dictionary, which the KeyValuePair will be added to.")]
        public InArgument<Dictionary<TKey, TValue>> Dictionary { get; set; }

        [Category("Input")]
        [RequiredArgument]
        [Description("The key object, which will be added to the target dictionary")]
        public InArgument<TKey> Key { get; set; }

        [Category("Input")]
        [RequiredArgument]
        [Description("The value object, which will be added to the target dictionary")]
        public InArgument<TValue> Value { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            var key = Key.Get(context);
            var value = Value.Get(context);
            Dictionary.Get(context).Add(key, value);
        }
    }
}
