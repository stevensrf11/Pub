using Prism.Events;
using System;
using XPub.Models.DataModels;
using XPub.Resources.Enums;

namespace XPub.Infrastructure.Prism.Events
{
    /// <summary>
    /// WaitCursorEvent object derived from <see cref="PubSubEvent"/>object with a type parameter of an 
    /// <seealso cref="WaitCursorEnums"/>.
    /// Used to indicate wait cursor event to perform
    /// </summary>
    public class WaitCursorEvent : PubSubEvent<Tuple<WaitCursorEnums, XPubWaitCursorDataModel>>
    {
    }
}
