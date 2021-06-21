package app

import (
	"github.com/gofiber/fiber/v2"
	"github.com/mrmlik12/vulder/search/app/controller"
)

func StartServer() {
	app := fiber.New()

	app.Get("/", controller.GetIndex)
	app.Post("/search/create", controller.Create)
	app.Get("/search", controller.GetSchools)

	app.Listen(":3000")
}
