package infrastructure

import (
	"context"
	"log"
	"time"

	"go.mongodb.org/mongo-driver/mongo"
	"go.mongodb.org/mongo-driver/mongo/options"
	"go.mongodb.org/mongo-driver/mongo/readpref"
)

type MongoDbContext struct {
	ctx               *context.Context
	client            *mongo.Client
	cancel            *context.CancelFunc
	schoolsCollection *mongo.Collection
}

func NewMongoDbContext(connectionString string) MongoDbContext {
	ctx, cancel := context.WithTimeout(context.Background(), 10*time.Second)

	client, err := mongo.Connect(ctx, options.Client().ApplyURI(connectionString))

	if err != nil {
		panic(err)
	}

	defer func() {
		if err = client.Disconnect(ctx); err != nil {
			panic(err)
		}
	}()

	if err := client.Ping(ctx, readpref.Primary()); err != nil {
		panic(err)
	}

	log.Println("successfully connected mongodb")

	return MongoDbContext{ctx: &ctx, client: client, cancel: &cancel, schoolsCollection: client.Database("Vulder").Collection("Schools")}
}
