# kafka-golang-python-test-project

- Kafka Deisgn Goal:
    - https://docs.confluent.io/kafka/design/index.html#design-overview
- Can't connect help:
    - https://www.confluent.io/blog/kafka-client-cannot-connect-to-broker-on-aws-on-docker-etc/
- Kafka Training Course
    - https://developer.confluent.io/courses/apache-kafka/events/
- Python client
    - https://docs.confluent.io/kafka-clients/python/current/overview.html
    - https://developer.confluent.io/get-started/python
- GoLang client
    - https://docs.confluent.io/kafka-clients/go/current/overview.html
    - https://developer.confluent.io/get-started/go/

# Testing
```bash

docker run \
    --rm \
    --network kafka-golang-python-test-project_default \
    confluentinc/confluent-cli \
    ls
``` 


# CLI Help

```bash
docker run \
    `# remove the container once it exits/stops` \
    --rm \
    `# connect to the same network created from compose` \
    --network kafka-golang-python-test-project_default \
    `# specify docker image` \
    confluentinc/confluent-cli \
    `# specify top level command and args within image` \
    confluent --help
```




# Create topic

```bash
docker run \
    `# remove the container once it exits/stops` \
    --rm \
    `# connect to the same network created from compose` \
    --network kafka-golang-python-test-project_default \
    `# specify docker image` \
    confluentinc/confluent-cli \
    `# specify top level command and args within image` \
    confluent local kafka topic create \
        purchases `# Topic name` \
        --config "advertised.listeners=PLAINTEXT://kafka-broker-1:9092,listeners=PLAINTEXT://kafka-broker-1:19092"
```


```bash
--config advertised.listeners=PLAINTEXT://kafka-broker-1:9092,listeners=PLAINTEXT://kafka-broker-1:19092
--config server.properties.advertised.listeners=PLAINTEXT://kafka-broker-1:9092,server.properties.listeners=PLAINTEXT://kafka-broker-1:19092
```




```bash
docker run --network=rmoff_kafka --rm --name python_kafka_test_client \
        --tty python_kafka_test_client broker:9092
```