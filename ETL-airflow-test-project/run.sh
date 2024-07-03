#!/bin/bash

docker compose \
    --file apache/docker-compose.yaml \
    --file docker-compose.yaml \
    --env-file .env \
    up


# docker compose \
#     --file apache/docker-compose.yaml \
#     --file docker-compose.yaml \
#     --env-file .env \
#     restart
#     jupyterlab
