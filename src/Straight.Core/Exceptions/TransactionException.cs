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

using System;
using System.Runtime.Serialization;

namespace Straight.Core.Exceptions
{
    public class TransactionException : SystemException
    {
        private static readonly string FullName = typeof(TransactionException).FullName;

        public TransactionException() : this($"A system exception ({FullName}) occurred")
        {
        }

        public TransactionException(string message) : base(message)
        {
        }

        public TransactionException(string message, Exception inner) : base(message, inner)
        {
        }

        protected TransactionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}