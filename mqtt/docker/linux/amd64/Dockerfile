﻿# Use the same base image as prod edgehub images
ARG base_tag=3.1.18-alpine3.13
FROM mcr.microsoft.com/dotnet/aspnet:${base_tag}

ADD ./x86_64-unknown-linux-musl/release/mqttd /usr/local/bin/mqttd

# Add an unprivileged user account for running mqttd	
ARG MQTTDUSER_ID=1000

RUN adduser -Du ${MQTTDUSER_ID} mqttduser

EXPOSE 1883/tcp
EXPOSE 8883/tcp

USER mqttduser

ENTRYPOINT ["/usr/local/bin/mqttd"]
