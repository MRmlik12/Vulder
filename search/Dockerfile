FROM golang:1.16.5-alpine3.14

WORKDIR /src

COPY * *

RUN go build -o /bin/search

WORKDIR /app

ENV MONGO_URL ""
EXPOSE 5000

ENTRYPOINT ["./search"]