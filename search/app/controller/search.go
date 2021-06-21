package controller

import (
	"github.com/gofiber/fiber/v2"
	"github.com/mrmlik12/vulder/search/infrastructure"
)

func GetSchools(c *fiber.Ctx) error {
	input := c.Params("input", "")

	school, err := infrastructure.CreateMongoDbService().GetSchools(input)

	if err != nil {
		c.JSON(fiber.Map{
			"error": err,
		})
	}

	return c.JSON(school)
}
