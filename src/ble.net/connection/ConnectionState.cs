// Copyright Malachi Griffie
// 
// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

namespace nexus.protocols.ble.connection
{
   /// <summary>
   /// The state of a remote connection
   /// </summary>
   public enum ConnectionState
   {
      Disconnected = 0,
      Disconnecting = 1,
      Connecting = 2,
      Connected = 3
   }
}