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

using NUnit.Framework;
using Straight.Core.Bus;

namespace Straight.Core.Tests.Bus
{
    [TestFixture]
    public class InMemoryActionQueueTests
    {
        [SetUp]
        public void Setup()
        {
            queue = new InMemoryActionQueue();
        }

        private InMemoryActionQueue queue;

        [Test]
        public void Should_call_action_when_pop_action_after_put_item()
        {
            var isCalled = false;
            queue.Put(new object());
            queue.Pop(obj => isCalled = true);
            Assert.That(isCalled);
        }

        [Test]
        public void Should_does_not_throw_exception_when_pop_new_action_in_nominal_case()
        {
            Assert.DoesNotThrow(() => queue.Pop(o => { }));
        }

        [Test]
        public void Should_does_not_throw_exception_when_put_new_item_without_action()
        {
            Assert.DoesNotThrow(() => queue.Put(new object()));
        }

        [Test]
        public void Should_execute_action_when_pop_action_and_put_object()
        {
            var isCalled = false;
            queue.Pop(obj => isCalled = true);
            queue.Put(new object());
            Assert.That(isCalled);
        }

        [Test]
        public void Should_not_call_action_when_not_put_item()
        {
            var isCalled = false;
            queue.Pop(obj => isCalled = true);
            Assert.That(isCalled, Is.False);
        }

        [Test]
        public void Should_not_call_action_when_put_item_without_action()
        {
            var isCalled = false;
            queue.Put(new object());
            Assert.That(isCalled, Is.False);
        }
    }
}