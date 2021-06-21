package main

import (
	"github.com/mrmlik12/vulder/search/app"
	"github.com/mrmlik12/vulder/search/infrastructure"
)

func main() {
	infrastructure.CreateMongoDbService()
	app.StartServer()
}
