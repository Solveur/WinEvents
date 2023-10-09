namespace WinEvents
{
	using static NativeMethods;

	public static class MouseMethods
	{
		/// <summary>
		/// Converts normalized 0-65535 coordinates to screen-space coordinates.
		/// </summary>
		/// <param name="position">
		/// Point, whose X and Y coordinates normalized to 0-65535 coordinate system.
		/// </param>
		/// <returns>Point in screen-space coordinates</returns>
		/// <exception cref="NullReferenceException"></exception>
		private static Point Denormalize(Point position)
		{
			Screen primaryScreen;
			if (Screen.PrimaryScreen != null)
				primaryScreen = Screen.PrimaryScreen;
			else
				throw new NullReferenceException();

			int x = (int)((float)position.X / primaryScreen.Bounds.Width * ushort.MaxValue);
			int y = (int)((float)position.Y / primaryScreen.Bounds.Height * ushort.MaxValue);

			return new Point(x, y);
		}

		/// <summary>
		/// Converts screen-space coordinates to normalized 0-65535 system.
		/// </summary>
		/// 
		/// <param name="position">
		/// Point, which represents position in screen-space of primary monitor
		/// </param>
		/// 
		/// <returns>
		/// Point in normalized 0-65535 coordinate system</returns>
		/// <exception cref="NullReferenceException">
		/// </exception>
		private static Point Normalize(Point position)
		{
			Screen primaryScreen;
			if (Screen.PrimaryScreen != null)
				primaryScreen = Screen.PrimaryScreen;
			else
				throw new NullReferenceException();

			int x = (int)((float)position.X / primaryScreen.Bounds.Width * ushort.MaxValue);
			int y = (int)((float)position.Y / primaryScreen.Bounds.Height * ushort.MaxValue);

			return new Point(x, y);
		}

		/// <summary>
		/// Converts screen-space coordinate to normalized 0-65535 system.
		/// </summary>
		/// 
		/// <param name="coordinate">
		/// Coordinate in screen-space of primary monitor by X or Y axis.
		/// </param>
		/// 
		/// <param name="normalizationFactor">
		/// <para>Size of axis, where coordinates are normalized.</para>
		/// <para>Basically, it's height or width of screen-space of primary monitor.</para>
		/// </param>
		/// 
		/// <returns>Point in normalized 0-65535 coordinate system</returns>
		private static int Normalize(int coordinate, int normalizationFactor)
		{
			int normalizedCoordinate = (int)((float)coordinate / normalizationFactor * ushort.MaxValue);

			return normalizedCoordinate;
		}

		/// <summary>
		/// Moves the cursor to the specified screen coordinates.
		/// </summary>
		/// <param name="newX">The new x-coordinate of the cursor, in screen coordinates.</param>
		/// <param name="newY">The new y-coordinate of the cursor, in screen coordinates.</param>
		public static void SendMouseMove(int newX, int newY)
		{
			Screen primaryScreen;
			if (Screen.PrimaryScreen != null)
				primaryScreen = Screen.PrimaryScreen;
			else
				throw new NullReferenceException();

			int dx = Normalize(newX, primaryScreen.Bounds.Width);
			int dy = Normalize(newY, primaryScreen.Bounds.Height);

			Input input = new()
			{
				type = InputType.Mouse,
				union = new InputUnion
				{
					mouse = new MouseInput
					{
						deltaX = dx,
						deltaY = dy,
						flags = MouseFlags.Absolute | MouseFlags.Move
					}
				}
			};

			SendInput(input);
		}


		/// <summary>
		/// Moves the cursor to the specified screen coordinates.
		/// </summary>
		/// <param name="point">The new coordinate of the cursor, in screen coordinates.</param>
		public static void SendMouseMove(Point point)
		{
			int x = Normalize(point).X;
			int y = Normalize(point).Y;

			Input input = new()
			{
				type = InputType.Mouse,
				union = new()
				{
					mouse = new()
					{
						deltaX = x,
						deltaY = y,
						flags = MouseFlags.Absolute | MouseFlags.Move
					}
				}
			};

			SendInput(input);
		}

		public static void SendMouseLClick()
		{
			Input[] inputs =
			[
				new()
				{
					type = InputType.Mouse,
					union = new()
					{
						mouse = new()
						{
							flags = MouseFlags.LeftDown
						}
					}
				},
				new()
				{
					type = InputType.Mouse,
					union = new()
					{
						mouse = new()
						{
							flags = MouseFlags.LeftUp
						}
					}
				},
			];
			SendInput(inputs);
		}
	}
}
