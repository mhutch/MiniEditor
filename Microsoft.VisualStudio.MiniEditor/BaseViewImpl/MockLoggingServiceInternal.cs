using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text.Utilities;

namespace Microsoft.VisualStudio.MiniEditor.BaseViewImpl
{
	[Export (typeof (ILoggingServiceInternal))]
	class MockLoggingServiceInternal : ILoggingServiceInternal
	{
		public void AdjustCounter (string key, string name, int delta = 1)
		{
		}

		public object CreateTelemetryOperationEventScope (string eventName, TelemetrySeverity severity, object[] correlations, IDictionary<string, object> startingProperties)
		{
			return null;
		}

		public void EndTelemetryScope (object telemetryScope, TelemetryResult result, string summary = null)
		{
		}

		public object GetCorrelationFromTelemetryScope (object telemetryScope)
		{
			return null;
		}

		public void PostCounters ()
		{
		}

		public void PostEvent (string key, params object[] namesAndProperties)
		{
		}

		public void PostEvent (string key, IReadOnlyList<object> namesAndProperties)
		{
		}

		public void PostEvent (TelemetryEventType eventType, string eventName, TelemetryResult result = TelemetryResult.Success, params (string name, object property)[] namesAndProperties)
		{
		}

		public void PostEvent (TelemetryEventType eventType, string eventName, TelemetryResult result, IReadOnlyList<(string name, object property)> namesAndProperties)
		{
		}

		public void PostFault (string eventName, string description, Exception exceptionObject, string additionalErrorInfo = null, bool? isIncludedInWatsonSample = null, object[] correlations = null)
		{
		}
	}
}