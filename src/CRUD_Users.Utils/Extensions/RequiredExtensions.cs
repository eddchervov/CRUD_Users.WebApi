using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CRUD_Users.Utils.Extensions
{
    public static class RequiredExtentions
    {
        public static void RequiredNotNull<T>(this T @object, string paramName, string message = null, object context = null)
            where T : class
        {
            if (@object != null)
            {
                return;
            }

            var messageParts = new List<string>
            {
                $"paramName: {paramName}"
            };

            if (string.IsNullOrEmpty(message) == false)
            {
                messageParts.Add(message);
            }

            if (context != null)
            {
                messageParts.Add($"context: {JsonConvert.SerializeObject(context)}");
            }

            var excMessage = string.Join(", ", messageParts);

            throw new InvalidOperationException(message: excMessage);
        }
    }
}
