using System;

namespace Common
{
	public class CommandResult<TResult>
	{
		public TResult Result
		{
			get;
			set;
		}

		public Exception Exception
		{
			get;
			set;
		}

		public bool IsSuccess
		{
			get;
			set;
		}

		private CommandResult()
		{
			IsSuccess = true;
		}

		private CommandResult(TResult result)
		{
			IsSuccess = true;
			Result = result;
		}

		private CommandResult(Exception exception)
		{
			IsSuccess = false;
			Exception = exception;
		}

		public CommandResult(TResult payload, bool failed)
		{
			IsSuccess = failed;
			Result = payload;
		}

		public static CommandResult<TResult> Success()
		{
			return new CommandResult<TResult>();
		}

		public static CommandResult<TResult> Success(TResult payload)
		{
			return new CommandResult<TResult>(payload);
		}

		public static CommandResult<TResult> Fail(Exception payload)
		{
			return new CommandResult<TResult>(payload);
		}

		public static CommandResult<TResult> Fail(TResult payload)
		{
			return new CommandResult<TResult>(payload, failed: false);
		}

		public static implicit operator bool(CommandResult<TResult> result)
		{
			return result.IsSuccess;
		}
	}
}
