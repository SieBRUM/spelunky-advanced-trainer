using System;

namespace SpelunkySuperTrainer
{
    public class HackScripts
    {
        readonly ProcessInformation ProcessInformation;

        public HackScripts(ProcessInformation processInformation)
        {
            this.ProcessInformation = processInformation;
        }

        public int GetHearts()
        {
            return GetMemoryValueInt32(ProcessInformation.hProc, ProcessInformation.moduleBaseAddress + 0x138558, new int[] { 0x30, 0x140 });
        }

        public int GetBombs()
        {
            return GetMemoryValueInt32(ProcessInformation.hProc, ProcessInformation.moduleBaseAddress + 0x138558, new int[] { 0x30, 0x280, 0x10 });
        }

        public int GetRopes()
        {
            return GetMemoryValueInt32(ProcessInformation.hProc, ProcessInformation.moduleBaseAddress + 0x138558, new int[] { 0x30, 0x280, 0x14 });
        }

        public int GetMoney()
        {
            return GetMemoryValueInt32(ProcessInformation.hProc, ProcessInformation.moduleBaseAddress + 0x1384B4, new int[] { 0x0044592c });
        }

        public int GetCurrentStage()
        {
            return GetMemoryValueInt32(ProcessInformation.hProc, ProcessInformation.moduleBaseAddress + 0x1384B4, new int[] { 0x4405d4 });
        }

        public float GetCurrentX()
        {
            return GetMemoryValueFloat(ProcessInformation.hProc, ProcessInformation.moduleBaseAddress + 0x138558, new int[] { 0x30, 0x30 });
        }

        public float GetCurrentY()
        {
            return GetMemoryValueFloat(ProcessInformation.hProc, ProcessInformation.moduleBaseAddress + 0x138558, new int[] { 0x30, 0x34 });
        }

        public void SetLeftTime(int time)
        {
            var leftTimeAddress = WinAPIWrapper.FindDMAAddy(ProcessInformation.hProc, ProcessInformation.moduleBaseAddress + 0x1384B4, new int[] { 0x445954 });
            WinAPIWrapper.WriteProcessMemory(ProcessInformation.hProc, leftTimeAddress, time, 4, out _);
        }

        public void SetRightTime(int time)
        {
            var rightTimeAddress = WinAPIWrapper.FindDMAAddy(ProcessInformation.hProc, ProcessInformation.moduleBaseAddress + 0x1384B4, new int[] { (0x445954 - 0x10) });
            WinAPIWrapper.WriteProcessMemory(ProcessInformation.hProc, rightTimeAddress, time, 4, out _);
        }

        public void SetHearts(int hearts)
        {
            if(hearts < 1)
            {
                return;
            }

            if(hearts > 99)
            {
                hearts = 99;
            }

            var hpAddress = WinAPIWrapper.FindDMAAddy(ProcessInformation.hProc, ProcessInformation.moduleBaseAddress + 0x138558, new int[] { 0x30, 0x140 });
            WinAPIWrapper.WriteProcessMemory(ProcessInformation.hProc, hpAddress, hearts, 4, out _);
        }

        public void SetBombs(int bombs)
        {
            if (bombs > 99)
            {
                bombs = 99;
            }

            var bombsAddress = WinAPIWrapper.FindDMAAddy(ProcessInformation.hProc, ProcessInformation.moduleBaseAddress + 0x138558, new int[] { 0x30, 0x280, 0x10 });
            WinAPIWrapper.WriteProcessMemory(ProcessInformation.hProc, bombsAddress, bombs, 4, out _);
        }

        public void SetRopes(int ropes)
        {
            if(ropes > 99)
            {
                ropes = 99;
            }

            var ropesAddress = WinAPIWrapper.FindDMAAddy(ProcessInformation.hProc, ProcessInformation.moduleBaseAddress + 0x138558, new int[] { 0x30, 0x280, 0x14 });
            WinAPIWrapper.WriteProcessMemory(ProcessInformation.hProc, ropesAddress, ropes, 4, out _);
        }

        public void SetMoney(int money)
        {
            if (money > 1874919423)
            {
                money = 1874919423;
            }

            var moneyAddress = WinAPIWrapper.FindDMAAddy(ProcessInformation.hProc, ProcessInformation.moduleBaseAddress + 0x1384B4, new int[] { 0x0044592c });
            WinAPIWrapper.WriteProcessMemory(ProcessInformation.hProc, moneyAddress, money, 4, out _);
        }

        public void SetStage(int stage)
        {
            var stageAddress = WinAPIWrapper.FindDMAAddy(ProcessInformation.hProc, ProcessInformation.moduleBaseAddress + 0x1384B4, new int[] { 0x4405d4 });
            WinAPIWrapper.WriteProcessMemory(ProcessInformation.hProc, stageAddress, stage, 4, out _);
        }

        public void TeleportPlayer(Vector2 location)
        {
            if(location == default)
            {
                throw new ArgumentException("Location cannot be null!");
            }

            var playerXAddress = WinAPIWrapper.FindDMAAddy(ProcessInformation.hProc, ProcessInformation.moduleBaseAddress + 0x138558, new int[] { 0x30, 0x30 });
            var playerYAddress = WinAPIWrapper.FindDMAAddy(ProcessInformation.hProc, ProcessInformation.moduleBaseAddress + 0x138558, new int[] { 0x30, 0x34 });

            WinAPIWrapper.WriteProcessMemory(ProcessInformation.hProc, playerXAddress, location.X, 4, out _);
            WinAPIWrapper.WriteProcessMemory(ProcessInformation.hProc, playerYAddress, location.Y, 4, out _);
        }

        public void SetCurrentHoldingItem(int itemId)
        {
            var playerHoldingItemAddress = WinAPIWrapper.FindDMAAddy(ProcessInformation.hProc, ProcessInformation.moduleBaseAddress + 0x138558, new int[] { 0x30, 0x280, 0x88 });
            WinAPIWrapper.WriteProcessMemory(ProcessInformation.hProc, playerHoldingItemAddress, itemId, 4, out _);
        }

        public Vector2 GetExitLocation()
        {
            return new Vector2()
            {
                X = GetMemoryValueFloat(ProcessInformation.hProc, ProcessInformation.moduleBaseAddress + 0x1384B4, new int[] { 0x3C, 0x1719C }),
                Y = GetMemoryValueFloat(ProcessInformation.hProc, ProcessInformation.moduleBaseAddress + 0x1384B4, new int[] { 0x3C, 0x171A0 })
            };
        }

        public void TeleportEntityToPlayer(int index)
        {
            var playerX = GetCurrentX();
            var playerY = GetCurrentY();

            var entityXAddress = WinAPIWrapper.FindDMAAddy(ProcessInformation.hProc, ProcessInformation.moduleBaseAddress + 0x1384B4, new int[] { 0x30, index, 0x30 });
            var entityYAddress = WinAPIWrapper.FindDMAAddy(ProcessInformation.hProc, ProcessInformation.moduleBaseAddress + 0x1384B4, new int[] { 0x30, index, 0x34 });
           
            WinAPIWrapper.WriteProcessMemory(ProcessInformation.hProc, entityXAddress, playerX, 4, out _);
            WinAPIWrapper.WriteProcessMemory(ProcessInformation.hProc, entityYAddress, playerY, 4, out _);
        }

        public EntityObject GetEntityObject(int index)
        {
            if(index < 0)
            {
                return null;
            }

            var entityId = GetMemoryValueInt32(ProcessInformation.hProc, ProcessInformation.moduleBaseAddress + 0x1384B4, new int[] { 0x30, index, 0x4 });

            // Object is not an entity

            if(entityId != 0 && entityId != index / 4)
            {
                return null;
            }

            var entityX = GetMemoryValueFloat(ProcessInformation.hProc, ProcessInformation.moduleBaseAddress + 0x1384B4, new int[] { 0x30, index, 0x30 });
            var entityY = GetMemoryValueFloat(ProcessInformation.hProc, ProcessInformation.moduleBaseAddress + 0x1384B4, new int[] { 0x30, index, 0x34 });
            var entityTypeId = GetMemoryValueInt32(ProcessInformation.hProc, ProcessInformation.moduleBaseAddress + 0x1384B4, new int[] { 0x30, index, 0xC });
            
            return new EntityObject() 
            { 
                Id = entityId,
                ObjectTypeId = entityTypeId,
                ObjectType = (ObjectTypes)entityTypeId,
                Position = new Vector2() 
                { 
                    X = entityX, Y = entityY
                }
            };
        }

        private int GetMemoryValueInt32(IntPtr hProc, IntPtr ptr, int[] offsets)
        {
            var address = WinAPIWrapper.FindDMAAddy(hProc, ptr, offsets);
            byte[] bytes = new byte[4];
            WinAPIWrapper.ReadProcessMemory(hProc, address, bytes, 4, out _);
            return BitConverter.ToInt32(bytes, 0);
        }

        private float GetMemoryValueFloat(IntPtr hProc, IntPtr ptr, int[] offsets)
        {
            var address = WinAPIWrapper.FindDMAAddy(hProc, ptr, offsets);
            byte[] bytes = new byte[4];
            WinAPIWrapper.ReadProcessMemory(hProc, address, bytes, 4, out _);
            return BitConverter.ToSingle(bytes, 0);
        }
    }
}
