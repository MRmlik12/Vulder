package infrastructure

import "github.com/google/wire"

func CreateMongoDbService() *MongoDbContext {
	panic(wire.Build(NewMongoDbContext))
}
