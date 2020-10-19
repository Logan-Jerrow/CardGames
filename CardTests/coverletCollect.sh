#!/bin/bash

rm -r `dirname "$0"`/TestResults/*
dotnet test --collect:"XPlat Code Coverage" --settings `dirname "$0"`/coverlet.runsettings.xml