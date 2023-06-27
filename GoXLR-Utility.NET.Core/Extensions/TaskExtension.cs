using System;
using System.Threading.Tasks;

namespace GoXLR_Utility.NET.Core.Extensions
{
    public static class TaskExtension {
        
        public static async void StepOver(this ValueTask valueTask, Action<Exception> @catch = null)
        {
            if (valueTask.IsCompleted)
                return;

            try
            {
                await valueTask;
            }
            catch (Exception ex) when (@catch != null)
            {
                @catch.Invoke(ex);
            }
        }
    
        public static async void StepOver(this Task task, Action<Exception> @catch = null)
        {
            if (task.IsCompleted)
                return;

            try
            {
                await task;
            }
            catch (Exception ex) when (@catch != null)
            {
                @catch.Invoke(ex);
            }
        }
        
        public static async void StepOver<T>(this ValueTask<T> valueTask, Action<Exception> @catch = null)
        {
            if (valueTask.IsCompleted)
                return;

            try
            {
                await valueTask;
            }
            catch (Exception ex) when (@catch != null)
            {
                @catch.Invoke(ex);
            }
        }
    
        public static async void StepOver<T>(this Task<T> task, Action<Exception> @catch = null)
        {
            if (task.IsCompleted)
                return;

            try
            {
                await task;
            }
            catch (Exception ex) when (@catch != null)
            {
                @catch.Invoke(ex);
            }
        }
    }
}