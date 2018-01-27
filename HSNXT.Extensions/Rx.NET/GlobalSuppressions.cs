﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information. 

// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Error List, point to "Suppress Message(s)", and click 
// "In Project Suppression File".
// You do not need to add suppressions to this file manually.

[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes",
        Scope = "namespace", Target = "System", Justification = "By design.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames",
        Justification = "Taken care of by lab build.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1016:MarkAssembliesWithAssemblyVersion",
        Justification = "Taken care of by lab build.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "0", Scope = "member",
        Target =
            "HSNXT.Reactive.Concurrency.LocalScheduler+WorkItem.#CompareTo(HSNXT.Reactive.Concurrency.LocalScheduler+WorkItem)",
        Justification = "Checked all enqueue operations against null reference insertions.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes",
        Scope = "namespace", Target = "HSNXT.Reactive", Justification = "By design.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes",
        Scope = "namespace", Target = "HSNXT.Reactive.Disposables", Justification = "By design.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes",
        Scope = "namespace", Target = "HSNXT.Reactive.Linq", Justification = "By design.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes",
        Scope = "namespace", Target = "HSNXT.Reactive.Subjects", Justification = "By design.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes",
        Scope = "namespace", Target = "HSNXT.Reactive.Concurrency", Justification = "By design.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes",
        Scope = "namespace", Target = "HSNXT.Reactive.Linq", Justification = "By design.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes",
        Scope = "namespace", Target = "HSNXT.Reactive.Threading.Tasks", Justification = "By design.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames",
        Justification = "Taken care of by lab build.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1016:MarkAssembliesWithAssemblyVersion",
        Justification = "Taken care of by lab build.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.AddRef`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Aggregate`2.#Run(System.IObserver`1<!1>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Aggregate`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.All`1.#Run(System.IObserver`1<System.Boolean>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Amb`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Any`1.#Run(System.IObserver`1<System.Boolean>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.AsObservable`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.AverageDecimal.#Run(System.IObserver`1<System.Decimal>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.AverageDecimalNullable.#Run(System.IObserver`1<System.Nullable`1<System.Decimal>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.AverageDouble.#Run(System.IObserver`1<System.Double>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.AverageDoubleNullable.#Run(System.IObserver`1<System.Nullable`1<System.Double>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.AverageInt32.#Run(System.IObserver`1<System.Double>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.AverageInt32Nullable.#Run(System.IObserver`1<System.Nullable`1<System.Double>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.AverageInt64.#Run(System.IObserver`1<System.Double>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.AverageInt64Nullable.#Run(System.IObserver`1<System.Nullable`1<System.Double>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.AverageSingle.#Run(System.IObserver`1<System.Single>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.AverageSingleNullable.#Run(System.IObserver`1<System.Nullable`1<System.Single>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Buffer`2.#Run(System.IObserver`1<System.Collections.Generic.IList`1<!0>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Buffer`1.#Run(System.IObserver`1<System.Collections.Generic.IList`1<!0>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Cast`2.#Run(System.IObserver`1<!1>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Catch`2.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Catch`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.CombineLatest`17.#Run(System.IObserver`1<!16>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.CombineLatest`16.#Run(System.IObserver`1<!15>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.CombineLatest`15.#Run(System.IObserver`1<!14>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.CombineLatest`14.#Run(System.IObserver`1<!13>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.CombineLatest`13.#Run(System.IObserver`1<!12>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.CombineLatest`12.#Run(System.IObserver`1<!11>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.CombineLatest`11.#Run(System.IObserver`1<!10>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.CombineLatest`10.#Run(System.IObserver`1<!9>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.CombineLatest`9.#Run(System.IObserver`1<!8>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.CombineLatest`8.#Run(System.IObserver`1<!7>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.CombineLatest`7.#Run(System.IObserver`1<!6>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.CombineLatest`6.#Run(System.IObserver`1<!5>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.CombineLatest`5.#Run(System.IObserver`1<!4>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.CombineLatest`4.#Run(System.IObserver`1<!3>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.CombineLatest`3.#Run(System.IObserver`1<!2>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.CombineLatest`2.#Run(System.IObserver`1<!1>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Concat`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Contains`1.#Run(System.IObserver`1<System.Boolean>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Count`1.#Run(System.IObserver`1<System.Int32>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.DefaultIfEmpty`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Defer`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Delay`2.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Delay`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.DelaySubscription`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "0", Scope = "member",
        Target = "HSNXT.Reactive.Linq.ObservableImpl.Dematerialize`1+_.#OnNext(HSNXT.Reactive.Notification`1<!0>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Dematerialize`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Distinct`2.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.DistinctUntilChanged`2.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Do`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "0", Scope = "member",
        Target = "HSNXT.Reactive.Either`2+Left.#Switch(System.Action`1<!0>,System.Action`1<!1>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "0", Scope = "member",
        Target = "HSNXT.Reactive.Either`2+Left.#Switch`1(System.Func`2<!0,!!0>,System.Func`2<!1,!!0>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "1", Scope = "member",
        Target = "HSNXT.Reactive.Either`2+Right.#Switch(System.Action`1<!0>,System.Action`1<!1>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "1", Scope = "member",
        Target = "HSNXT.Reactive.Either`2+Right.#Switch`1(System.Func`2<!0,!!0>,System.Func`2<!1,!!0>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.ElementAt`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Empty`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Finally`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.FirstAsync`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Generate`2.#Run(System.IObserver`1<!1>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.GroupBy`3.#Run(System.IObserver`1<HSNXT.Reactive.Linq.IGroupedObservable`2<!1,!2>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.GroupByUntil`4.#Run(System.IObserver`1<HSNXT.Reactive.Linq.IGroupedObservable`2<!1,!2>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.GroupJoin`5.#Run(System.IObserver`1<!4>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.IgnoreElements`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.IsEmpty`1.#Run(System.IObserver`1<System.Boolean>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Join`5.#Run(System.IObserver`1<!4>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "0", Scope = "member",
        Target = "HSNXT.Reactive.Joins.JoinObserver`1.#OnNextCore(HSNXT.Reactive.Notification`1<!0>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.LastAsync`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.LongCount`1.#Run(System.IObserver`1<System.Int64>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Materialize`1.#Run(System.IObserver`1<HSNXT.Reactive.Notification`1<!0>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Max`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.MaxBy`2.#Run(System.IObserver`1<System.Collections.Generic.IList`1<!0>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.MaxDecimal.#Run(System.IObserver`1<System.Decimal>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.MaxDecimalNullable.#Run(System.IObserver`1<System.Nullable`1<System.Decimal>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.MaxDouble.#Run(System.IObserver`1<System.Double>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.MaxDoubleNullable.#Run(System.IObserver`1<System.Nullable`1<System.Double>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.MaxInt32.#Run(System.IObserver`1<System.Int32>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.MaxInt32Nullable.#Run(System.IObserver`1<System.Nullable`1<System.Int32>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.MaxInt64.#Run(System.IObserver`1<System.Int64>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.MaxInt64Nullable.#Run(System.IObserver`1<System.Nullable`1<System.Int64>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.MaxSingle.#Run(System.IObserver`1<System.Single>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.MaxSingleNullable.#Run(System.IObserver`1<System.Nullable`1<System.Single>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Merge`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Min`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.MinBy`2.#Run(System.IObserver`1<System.Collections.Generic.IList`1<!0>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.MinDecimal.#Run(System.IObserver`1<System.Decimal>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.MinDecimalNullable.#Run(System.IObserver`1<System.Nullable`1<System.Decimal>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.MinDouble.#Run(System.IObserver`1<System.Double>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.MinDoubleNullable.#Run(System.IObserver`1<System.Nullable`1<System.Double>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.MinInt32.#Run(System.IObserver`1<System.Int32>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.MinInt32Nullable.#Run(System.IObserver`1<System.Nullable`1<System.Int32>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.MinInt64.#Run(System.IObserver`1<System.Int64>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.MinInt64Nullable.#Run(System.IObserver`1<System.Nullable`1<System.Int64>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.MinSingle.#Run(System.IObserver`1<System.Single>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.MinSingleNullable.#Run(System.IObserver`1<System.Nullable`1<System.Single>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Multicast`3.#Run(System.IObserver`1<!2>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.OfType`2.#Run(System.IObserver`1<!1>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.OnErrorResumeNext`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Range.#Run(System.IObserver`1<System.Int32>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.RefCount`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Repeat`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Return`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Sample`2.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Sample`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Scan`2.#Run(System.IObserver`1<!1>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Scan`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Select`2.#Run(System.IObserver`1<!1>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.SelectMany`3.#Run(System.IObserver`1<!2>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.SelectMany`2.#Run(System.IObserver`1<!1>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.SequenceEqual`1.#Run(System.IObserver`1<System.Boolean>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.SingleAsync`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Skip`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.SkipLast`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.SkipUntil`2.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.SkipUntil`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.SkipWhile`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.SumDecimal.#Run(System.IObserver`1<System.Decimal>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.SumDecimalNullable.#Run(System.IObserver`1<System.Nullable`1<System.Decimal>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.SumDouble.#Run(System.IObserver`1<System.Double>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.SumDoubleNullable.#Run(System.IObserver`1<System.Nullable`1<System.Double>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.SumInt32.#Run(System.IObserver`1<System.Int32>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.SumInt32Nullable.#Run(System.IObserver`1<System.Nullable`1<System.Int32>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.SumInt64.#Run(System.IObserver`1<System.Int64>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.SumInt64Nullable.#Run(System.IObserver`1<System.Nullable`1<System.Int64>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.SumSingle.#Run(System.IObserver`1<System.Single>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.SumSingleNullable.#Run(System.IObserver`1<System.Nullable`1<System.Single>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Switch`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Take`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.TakeLast`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.TakeUntil`2.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.TakeUntil`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.TakeWhile`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Throttle`2.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Throttle`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Throw`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.TimeInterval`1.#Run(System.IObserver`1<HSNXT.Reactive.TimeInterval`1<!0>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Timeout`2.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Timeout`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Timer.#Run(System.IObserver`1<System.Int64>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Timestamp`1.#Run(System.IObserver`1<HSNXT.Reactive.Timestamped`1<!0>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.ToArray`1.#Run(System.IObserver`1<!0[]>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.ToDictionary`3.#Run(System.IObserver`1<System.Collections.Generic.IDictionary`2<!1,!2>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.ToList`1.#Run(System.IObserver`1<System.Collections.Generic.IList`1<!0>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.ToLookup`3.#Run(System.IObserver`1<System.Linq.ILookup`2<!1,!2>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.ToObservable`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Using`2.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Where`1.#Run(System.IObserver`1<!0>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Window`2.#Run(System.IObserver`1<System.IObservable`1<!0>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Window`1.#Run(System.IObserver`1<System.IObservable`1<!0>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Zip`17.#Run(System.IObserver`1<!16>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Zip`16.#Run(System.IObserver`1<!15>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Zip`15.#Run(System.IObserver`1<!14>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Zip`14.#Run(System.IObserver`1<!13>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Zip`13.#Run(System.IObserver`1<!12>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Zip`12.#Run(System.IObserver`1<!11>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Zip`11.#Run(System.IObserver`1<!10>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Zip`10.#Run(System.IObserver`1<!9>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Zip`9.#Run(System.IObserver`1<!8>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Zip`8.#Run(System.IObserver`1<!7>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Zip`7.#Run(System.IObserver`1<!6>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Zip`6.#Run(System.IObserver`1<!5>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Zip`4.#Run(System.IObserver`1<!3>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Zip`3.#Run(System.IObserver`1<!2>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Zip`1.#Run(System.IObserver`1<System.Collections.Generic.IList`1<!0>>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "2", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.ObservableImpl.Zip`5.#Run(System.IObserver`1<!4>,System.IDisposable,System.Action`1<System.IDisposable>)",
        Justification = "Producer cannot pass null to setSink parameter.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly",
        Scope = "member", Target = "HSNXT.Reactive.Linq.ObservableImpl.ElementAt`1+_.#OnCompleted()",
        Justification = "Asynchronous behavior; no more index parameter in scope.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes",
        Scope = "namespace", Target = "HSNXT.Reactive.Concurrency", Justification = "By design.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes",
        Scope = "namespace", Target = "HSNXT.Reactive.PlatformServices", Justification = "By design.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames",
        Justification = "Taken care of by lab build.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1016:MarkAssembliesWithAssemblyVersion",
        Justification = "Taken care of by lab build.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes",
        Scope = "namespace", Target = "HSNXT.Reactive.Linq", Justification = "By design")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly",
        MessageId = "Qbservable", Scope = "type", Target = "HSNXT.Reactive.Linq.IQbservable",
        Justification = "It's homoiconic, dude!")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly",
        MessageId = "Qbservable", Scope = "type", Target = "HSNXT.Reactive.Linq.IQbservable`1",
        Justification = "It's homoiconic, dude!")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly",
        MessageId = "Qbservable", Scope = "type", Target = "HSNXT.Reactive.Linq.IQbservableProvider",
        Justification = "It's homoiconic, dude!")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly",
        MessageId = "Qbservable", Scope = "type", Target = "HSNXT.Reactive.Linq.Qbservable",
        Justification = "It's homoiconic, dude!")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly",
        MessageId = "Amb", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.Qbservable.#Amb`1(HSNXT.Reactive.Linq.IQbservable`1<!!0>,System.IObservable`1<!!0>)",
        Justification = "It's homoiconic, dude!")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly",
        MessageId = "Amb", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.Qbservable.#Amb`1(HSNXT.Reactive.Linq.IQbservableProvider,System.Collections.Generic.IEnumerable`1<System.IObservable`1<!!0>>)",
        Justification = "It's homoiconic, dude!")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly",
        MessageId = "Amb", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.Qbservable.#Amb`1(HSNXT.Reactive.Linq.IQbservableProvider,System.IObservable`1<!!0>[])",
        Justification = "It's homoiconic, dude!")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly",
        MessageId = "Qbservable", Scope = "member",
        Target = "HSNXT.Reactive.Linq.Qbservable.#AsQbservable`1(System.IObservable`1<!!0>)",
        Justification = "It's homoiconic, dude!")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly",
        MessageId = "Remotable", Scope = "member",
        Target = "HSNXT.Reactive.Linq.Qbservable.#Remotable`1(HSNXT.Reactive.Linq.IQbservable`1<!!0>)",
        Justification = "It's homoiconic, dude!")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly",
        MessageId = "Qbservable", Scope = "member",
        Target = "HSNXT.Reactive.Linq.Qbservable.#ToQbservable`1(System.Linq.IQueryable`1<!!0>)",
        Justification = "It's homoiconic, dude!")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming",
        "CA1703:ResourceStringsShouldBeSpelledCorrectly", MessageId = "Qbservable", Scope = "resource",
        Target = "HSNXT.Reactive.Strings_Providers.resources", Justification = "It's homoiconic, dude!")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly",
        MessageId = "Qbservable", Scope = "member",
        Target =
            "HSNXT.Reactive.Linq.Qbservable.#ToQbservable`1(System.Linq.IQueryable`1<!!0>,HSNXT.Reactive.Concurrency.IScheduler)",
        Justification = "It's homoiconic, dude!")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "0", Scope = "member",
        Target =
            "HSNXT.Reactive.ObservableQuery`1+ObservableRewriter.#VisitConstant(System.Linq.Expressions.ConstantExpression)",
        Justification = "Expression visitor should not pass in null references.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "0", Scope = "member",
        Target =
            "HSNXT.Reactive.ObservableQuery`1+ObservableRewriter.#VisitMethodCall(System.Linq.Expressions.MethodCallExpression)",
        Justification = "Expression visitor should not pass in null references.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames",
        Justification = "Taken care of by lab build.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1016:MarkAssembliesWithAssemblyVersion",
        Justification = "Taken care of by lab build.")]