[![Build Status](https://travis-ci.org/lloydjatkinson/log-wrap.svg?branch=master)](https://travis-ci.org/lloydjatkinson/log-wrap)

# LogWrap #

A .NET Standard 2.0 class library that provides a simple abstraction over logging frameworks, which allows the logging framework to be swapped without requiring changes of application code.

The goal of this library is to allow me to decouple my libraries/applications from any specific logging framework. Previously, I would write a logging abstraction (`ILogger`/`ILoggerFactory`) in each application. This became repetitive, so I created this library that I could then simply install from NuGet.
