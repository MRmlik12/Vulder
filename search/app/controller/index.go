package controller

import "github.com/gofiber/fiber/v2"

func GetIndex(c *fiber.Ctx) error {
	return c.JSON(fiber.Map{
		"version": 1,
	})
}
