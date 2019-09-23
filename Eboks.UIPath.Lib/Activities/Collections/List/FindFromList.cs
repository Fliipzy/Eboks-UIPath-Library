using System;
using System.Collections.Generic;
using System.Activities;
using System.ComponentModel;

namespace Eboks.UIPath.Lib.Activities.Collections.List
{
    class FindFirstFromList<T> : CodeActivity
    {
        [Category("Input")]
        [RequiredArgument]
        public InArgument<List<T>> List { get; set; }

        [Category("Input")]
        [RequiredArgument]
        public InArgument<Predicate<T>> Predicate { get; set; }
        
        [Category("Output")]
        public OutArgument<T> Result { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            var list = List.Get(context);
            var predicate = Predicate.Get(context);
            var result = list.Find(predicate);
            Result.Set(context, result);
        }
    }
}
