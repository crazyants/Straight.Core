﻿// ==============================================================================================================
// Straight Compagny
// Straight Core
// ==============================================================================================================
// ©2016 Straight Compagny. All rights reserved.
// Licensed under the MIT License (MIT); you may not use this file except in compliance
// with the License. You may obtain have a last condition or last licence at https://github.com/straightcore/Straight.Core/blob/master
// Unless required by applicable law or agreed to in writing, software distributed under the License is
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and limitations under the License.
// ==============================================================================================================

using Straight.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Straight.Core.Extensions.Domain
{
    public static class ApplyEventExtensions
    {
        public static void Apply(this IReadOnlyDictionary<Type, MethodInfo> registerMethods, object model, object @event)
        {
            MethodInfo handler;
            if (!registerMethods.TryGetValue(@event.GetType(), out handler))
            {
                throw new UnregisteredDomainEventException(
                    $"The domain event '{@event.GetType().FullName}' is not registered in '{model.GetType().FullName}'");
            }
            handler.Invoke(model, new object[] {@event});
            return;
        }
    }
}