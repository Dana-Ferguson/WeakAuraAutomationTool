using System;

namespace WeakAuraAutomationTool.Automation.Positioning
{
    public class AuraGrid
    {
        public Point Origin = new Point();
        public int Width = 2;
        public int Height = 5;
        public int Size = 50;
        /// <summary>The placement of the next aura until we reach the end of the grid line.</summary>
        public Direction InLine = Direction.Right;
        /// <summary>The placement of the next grid line in the grid, relative to the last grid line.</summary>
        public Direction NextLine = Direction.Down;

        // public Point Location { get; private set; } = null;
        public Point Location { get; internal set; } = null;
        public int Position { get; private set; } = -1;

        public void Reset()
        {
            Location = null;
            Position = -1;
        }

        public Point Next()
        {
            if (Location == null)
            {
                Position = 0;
                return Location = new Point(Origin.X, Origin.Y);
            }

            Move(InLine);
            if (OutOfBounds())
            {
                Move(NextLine);
                ResetLine();
            }

            Position++;
            return Location;
        }

        public AuraGrid Clone()
        {
            return new AuraGrid
            {
                Origin = new Point(Origin.X, Origin.Y),
                Width = Width,
                Height = Height,
                Size = Size,
                InLine = InLine,
                NextLine = NextLine
            };
        }

        public string GetUpdateLua() => GetMoveLua(InLine);

        public string GetNextLineLua() => GetMoveLua(NextLine);

        public int DeltaY => Location.Y - Origin.Y;
        public int DeltaX => Location.X - Origin.X;

        public string GetBoundsCheckLua()
        {
            return InLine switch
            {
                Direction.Up => $"yOffset >= {Height * Size + DeltaY}",
                Direction.Down => $"yOffset <= {-Height * Size - DeltaY}",
                Direction.Left => $"xOffset <= {-Width * Size - DeltaX}",
                Direction.Right => $"xOffset >= {Width * Size + DeltaX}",
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        public string GetResetLineLua()
        {
            return InLine switch
            {
                Direction.Up => $"yOffset = {-DeltaY}",
                Direction.Down => $"yOffset = {-DeltaY}",
                Direction.Left => $"xOffset = {-DeltaX}",
                Direction.Right => $"xOffset = {-DeltaX}",
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        public int ResetLine()
        {
            return InLine switch
            {
                Direction.Up => Location.Y = Origin.Y,
                Direction.Down => Location.Y = Origin.Y,
                Direction.Left => Location.X = Origin.X,
                Direction.Right => Location.X = Origin.X,
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        private string GetMoveLua(Direction direction)
        {
            return direction switch
            {
                Direction.Up => $"yOffset = yOffset + {Size}",
                Direction.Down => $"yOffset = yOffset - {Size}",
                Direction.Left => $"xOffset = xOffset - {Size}",
                Direction.Right => $"xOffset = xOffset + {Size}",
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        private int Move(Direction direction)
        {
            return direction switch
            {
                Direction.Up => Location.Y += Size,
                Direction.Down => Location.Y -= Size,
                Direction.Left => Location.X -= Size,
                Direction.Right => Location.X += Size,
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        private bool OutOfBounds()
        {
            return InLine switch
            {
                Direction.Up => Location.Y - Origin.Y >= Height * Size,
                Direction.Down => Location.Y - Origin.Y <= -Height * Size,
                Direction.Left => Location.X - Origin.X <= -Width * Size,
                Direction.Right => Location.X - Origin.X >= Width * Size,
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}