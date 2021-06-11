using System;
using Xunit;
using IIG.BinaryFlag;
using IIG.DatabaseConnectionUtils;
using IIG.PasswordHashingUtils;
using IIG.CoSFE.DatabaseUtils;
using IIG.Core.FileWorkingUtils;

namespace FourthLab
{
	public class TestClassFile
	{
		ulong minValue = 2;
		ulong maxValue = 17179868704;
		string destination = "../destination.txt";

		// GetFlag Tests

		[Fact]
		public void GetFlag_NothingEqual_MinValue()
		{
			MultipleBinaryFlag flag = new MultipleBinaryFlag(minValue);

			bool? exp = flag.GetFlag();
			string expAsText = exp.ToString();

			bool isWriteSuccesful = FileWorker.TryWrite(expAsText, destination);
			Assert.True(isWriteSuccesful);

			string actAsText = FileWorker.ReadAll(destination);
			bool? act = Convert.ToBoolean(actAsText);

			Assert.Equal(exp, act);
			Assert.Equal(expAsText, actAsText);
		}

		[Fact]
		public void GetFlag_NothingEqual_MoreThanMinValue()
		{
			MultipleBinaryFlag flag = new MultipleBinaryFlag(minValue + 1);

			bool? exp = flag.GetFlag();
			string expAsText = exp.ToString();

			bool isWriteSuccesful = FileWorker.TryWrite(expAsText, destination);
			Assert.True(isWriteSuccesful);

			string actAsText = FileWorker.ReadAll(destination);
			bool? act = Convert.ToBoolean(actAsText);

			Assert.Equal(exp, act);
			Assert.Equal(expAsText, actAsText);
		}

		[Fact]
		public void GetFlag_TrueEqual_MinValue()
		{
			MultipleBinaryFlag flag = new MultipleBinaryFlag(minValue, true);

			bool? exp = flag.GetFlag();
			string expAsText = exp.ToString();

			bool isWriteSuccesful = FileWorker.TryWrite(expAsText, destination);
			Assert.True(isWriteSuccesful);

			string actAsText = FileWorker.ReadAll(destination);
			bool? act = Convert.ToBoolean(actAsText);

			Assert.Equal(exp, act);
			Assert.Equal(expAsText, actAsText);
		}

		[Fact]
		public void GetFlag_TrueEqual_MoreThanMinValue()
		{
			MultipleBinaryFlag flag = new MultipleBinaryFlag(minValue + 1, true);

			bool? exp = flag.GetFlag();
			string expAsText = exp.ToString();

			bool isWriteSuccesful = FileWorker.TryWrite(expAsText, destination);
			Assert.True(isWriteSuccesful);

			string actAsText = FileWorker.ReadAll(destination);
			bool? act = Convert.ToBoolean(actAsText);

			Assert.Equal(exp, act);
			Assert.Equal(expAsText, actAsText);
		}

		[Fact]
		public void GetFlag_FalseEqual_MinValue()
		{
			MultipleBinaryFlag flag = new MultipleBinaryFlag(minValue, false);

			bool? exp = flag.GetFlag();
			string expAsText = exp.ToString();

			bool isWriteSuccesful = FileWorker.TryWrite(expAsText, destination);
			Assert.True(isWriteSuccesful);

			string actAsText = FileWorker.ReadAll(destination);
			bool? act = Convert.ToBoolean(actAsText);

			Assert.Equal(exp, act);
			Assert.Equal(expAsText, actAsText);
		}

		[Fact]
		public void GetFlag_FalseEqual_MoreThanMinValue()
		{
			MultipleBinaryFlag flag = new MultipleBinaryFlag(minValue + 1, false);

			bool? exp = flag.GetFlag();
			string expAsText = exp.ToString();

			bool isWriteSuccesful = FileWorker.TryWrite(expAsText, destination);
			Assert.True(isWriteSuccesful);

			string actAsText = FileWorker.ReadAll(destination);
			bool? act = Convert.ToBoolean(actAsText);

			Assert.Equal(exp, act);
			Assert.Equal(expAsText, actAsText);
		}

		[Fact]
		public void GetFlag_NothingEqual_MaxValue()
		{
			MultipleBinaryFlag flag = new MultipleBinaryFlag(maxValue);

			bool? exp = flag.GetFlag();
			string expAsText = exp.ToString();

			bool isWriteSuccesful = FileWorker.TryWrite(expAsText, destination);
			Assert.True(isWriteSuccesful);

			string actAsText = FileWorker.ReadAll(destination);
			bool? act = Convert.ToBoolean(actAsText);

			Assert.Equal(exp, act);
			Assert.Equal(expAsText, actAsText);
		}

		[Fact]
		public void GetFlag_NothingEqual_LessThanMaxValue()
		{
			MultipleBinaryFlag flag = new MultipleBinaryFlag(maxValue - 1);

			bool? exp = flag.GetFlag();
			string expAsText = exp.ToString();

			bool isWriteSuccesful = FileWorker.TryWrite(expAsText, destination);
			Assert.True(isWriteSuccesful);

			string actAsText = FileWorker.ReadAll(destination);
			bool? act = Convert.ToBoolean(actAsText);

			Assert.Equal(exp, act);
			Assert.Equal(expAsText, actAsText);
		}

		[Fact]
		public void GetFlag_TrueEqual_MaxValue()
		{
			MultipleBinaryFlag flag = new MultipleBinaryFlag(maxValue, true);

			bool? exp = flag.GetFlag();
			string expAsText = exp.ToString();

			bool isWriteSuccesful = FileWorker.TryWrite(expAsText, destination);
			Assert.True(isWriteSuccesful);

			string actAsText = FileWorker.ReadAll(destination);
			bool? act = Convert.ToBoolean(actAsText);

			Assert.Equal(exp, act);
			Assert.Equal(expAsText, actAsText);
		}

		[Fact]
		public void GetFlag_TrueEqual_LessThanMaxValue()
		{
			MultipleBinaryFlag flag = new MultipleBinaryFlag(maxValue - 1, true);

			bool? exp = flag.GetFlag();
			string expAsText = exp.ToString();

			bool isWriteSuccesful = FileWorker.TryWrite(expAsText, destination);
			Assert.True(isWriteSuccesful);

			string actAsText = FileWorker.ReadAll(destination);
			bool? act = Convert.ToBoolean(actAsText);

			Assert.Equal(exp, act);
			Assert.Equal(expAsText, actAsText);
		}

		[Fact]
		public void GetFlag_FalseEqual_MaxValue()
		{
			MultipleBinaryFlag flag = new MultipleBinaryFlag(maxValue, false);

			bool? exp = flag.GetFlag();
			string expAsText = exp.ToString();

			bool isWriteSuccesful = FileWorker.TryWrite(expAsText, destination);
			Assert.True(isWriteSuccesful);

			string actAsText = FileWorker.ReadAll(destination);
			bool? act = Convert.ToBoolean(actAsText);

			Assert.Equal(exp, act);
			Assert.Equal(expAsText, actAsText);
		}

		[Fact]
		public void GetFlag_FalseEqual_LessThanMaxValue()
		{
			MultipleBinaryFlag flag = new MultipleBinaryFlag(maxValue - 1, false);

			bool? exp = flag.GetFlag();
			string expAsText = exp.ToString();

			bool isWriteSuccesful = FileWorker.TryWrite(expAsText, destination);
			Assert.True(isWriteSuccesful);

			string actAsText = FileWorker.ReadAll(destination);
			bool? act = Convert.ToBoolean(actAsText);

			Assert.Equal(exp, act);
			Assert.Equal(expAsText, actAsText);
		}

		// Use MultipleBinaryFlag as Text Tests

		[Fact]
		public void FlagAsText_NothingEqual_MinValue()
		{
			MultipleBinaryFlag flag = new MultipleBinaryFlag(minValue);

			string expAsText = flag.ToString();

			bool isWriteSuccesful = FileWorker.TryWrite(expAsText, destination);
			Assert.True(isWriteSuccesful);

			string actAsText = FileWorker.ReadAll(destination);

			Assert.Equal(expAsText, actAsText);
		}

		[Fact]
		public void FlagAsText_NothingEqual_MoreThanMinValue()
		{
			MultipleBinaryFlag flag = new MultipleBinaryFlag(minValue + 1);

			string expAsText = flag.ToString();

			bool isWriteSuccesful = FileWorker.TryWrite(expAsText, destination);
			Assert.True(isWriteSuccesful);

			string actAsText = FileWorker.ReadAll(destination);

			Assert.Equal(expAsText, actAsText);
		}

		[Fact]
		public void FlagAsText_TrueEqual_MinValue()
		{
			MultipleBinaryFlag flag = new MultipleBinaryFlag(minValue, true);

			string expAsText = flag.ToString();

			bool isWriteSuccesful = FileWorker.TryWrite(expAsText, destination);
			Assert.True(isWriteSuccesful);

			string actAsText = FileWorker.ReadAll(destination);

			Assert.Equal(expAsText, actAsText);
		}

		[Fact]
		public void FlagAsText_TrueEqual_MoreThanMinValue()
		{
			MultipleBinaryFlag flag = new MultipleBinaryFlag(minValue + 1, true);

			string expAsText = flag.ToString();

			bool isWriteSuccesful = FileWorker.TryWrite(expAsText, destination);
			Assert.True(isWriteSuccesful);

			string actAsText = FileWorker.ReadAll(destination);

			Assert.Equal(expAsText, actAsText);
		}

		[Fact]
		public void FlagAsText_FalseEqual_MinValue()
		{
			MultipleBinaryFlag flag = new MultipleBinaryFlag(minValue, false);

			string expAsText = flag.ToString();

			bool isWriteSuccesful = FileWorker.TryWrite(expAsText, destination);
			Assert.True(isWriteSuccesful);

			string actAsText = FileWorker.ReadAll(destination);

			Assert.Equal(expAsText, actAsText);
		}

		[Fact]
		public void FlagAsText_FalseEqual_MoreThanMinValue()
		{
			MultipleBinaryFlag flag = new MultipleBinaryFlag(minValue + 1, false);

			string expAsText = flag.ToString();

			bool isWriteSuccesful = FileWorker.TryWrite(expAsText, destination);
			Assert.True(isWriteSuccesful);

			string actAsText = FileWorker.ReadAll(destination);

			Assert.Equal(expAsText, actAsText);
		}

		// Dispose Tests

		[Fact]
		public void Dispose_NothingEqual_MinValue()
		{
			MultipleBinaryFlag flag = new MultipleBinaryFlag(minValue);

			flag.Dispose();
			bool? exp = flag.GetFlag();
			string expAsText = exp.ToString();

			bool isWriteSuccesful = FileWorker.TryWrite(expAsText, destination);
			Assert.True(isWriteSuccesful);

			string actAsText = FileWorker.ReadAll(destination);

			Assert.Equal(expAsText, actAsText);
		}

		[Fact]
		public void Dispose_NothingEqual_MoreThanMinValue()
		{
			MultipleBinaryFlag flag = new MultipleBinaryFlag(minValue + 1);

			flag.Dispose();
			bool? exp = flag.GetFlag();
			string expAsText = exp.ToString();

			bool isWriteSuccesful = FileWorker.TryWrite(expAsText, destination);
			Assert.True(isWriteSuccesful);

			string actAsText = FileWorker.ReadAll(destination);

			Assert.Equal(expAsText, actAsText);
		}

		[Fact]
		public void Dispose_TrueEqual_MinValue()
		{
			MultipleBinaryFlag flag = new MultipleBinaryFlag(minValue, true);

			flag.Dispose();
			bool? exp = flag.GetFlag();
			string expAsText = exp.ToString();

			bool isWriteSuccesful = FileWorker.TryWrite(expAsText, destination);
			Assert.True(isWriteSuccesful);

			string actAsText = FileWorker.ReadAll(destination);

			Assert.Equal(expAsText, actAsText);
		}

		[Fact]
		public void Dispose_TrueEqual_MoreThanMinValue()
		{
			MultipleBinaryFlag flag = new MultipleBinaryFlag(minValue + 1, true);

			flag.Dispose();
			bool? exp = flag.GetFlag();
			string expAsText = exp.ToString();

			bool isWriteSuccesful = FileWorker.TryWrite(expAsText, destination);
			Assert.True(isWriteSuccesful);

			string actAsText = FileWorker.ReadAll(destination);

			Assert.Equal(expAsText, actAsText);
		}

		[Fact]
		public void Dispose_FalseEqual_MinValue()
		{
			MultipleBinaryFlag flag = new MultipleBinaryFlag(minValue, false);

			flag.Dispose();
			bool? exp = flag.GetFlag();
			string expAsText = exp.ToString();

			bool isWriteSuccesful = FileWorker.TryWrite(expAsText, destination);
			Assert.True(isWriteSuccesful);

			string actAsText = FileWorker.ReadAll(destination);

			Assert.Equal(expAsText, actAsText);
		}

		[Fact]
		public void Dispose_FalseEqual_MoreThanMinValue()
		{
			MultipleBinaryFlag flag = new MultipleBinaryFlag(minValue + 1, false);

			flag.Dispose();
			bool? exp = flag.GetFlag();
			string expAsText = exp.ToString();

			bool isWriteSuccesful = FileWorker.TryWrite(expAsText, destination);
			Assert.True(isWriteSuccesful);

			string actAsText = FileWorker.ReadAll(destination);

			Assert.Equal(expAsText, actAsText);
		}

	}

	public class TestClassDB
	{
		private const string Server = @"Nikita";
		private const string Database = @"IIG.CoSWE.AuthDB";
		private const bool IsTrusted = true;
		private const string Login = @"coswe";
		private const string Password = @"L}EjpfCgru9X@GLj";
		private const int ConnectionTimeout = 75;

		static readonly AuthDatabaseUtils database = new(Server, Database,
			IsTrusted, Login, Password, ConnectionTimeout);

		[Fact]
		public void Test1()
		{

		}
	}
}
