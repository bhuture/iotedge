﻿ARG base_tag=3.1.18-alpine3.13
FROM mcr.microsoft.com/dotnet/runtime:${base_tag}

ARG EXE_DIR=.

ENV MODULE_NAME "NumberLogger.dll"

WORKDIR /app

COPY $EXE_DIR/ ./

# Add an unprivileged user account for running the module
RUN adduser -Ds /bin/sh moduleuser 
USER moduleuser

ENTRYPOINT /usr/bin/dotnet NumberLogger.dll
