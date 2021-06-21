package controller

import (
	"encoding/json"

	"github.com/gofiber/fiber/v2"
	"github.com/mrmlik12/vulder/search/app/model"
	"github.com/mrmlik12/vulder/search/domain/entity"
	"github.com/mrmlik12/vulder/search/domain/repository"
	"github.com/mrmlik12/vulder/search/infrastructure"
)

func Create(c *fiber.Ctx) error {
	schoolDTO := model.SchoolDTO{}
	json.Unmarshal([]byte(c.Body()), &schoolDTO)

	if infrastructure.IsEmpty(schoolDTO.Name) {
		c.JSON(fiber.Map{
			"errror": "Name is empty",
		})
	}

	if matched, _ := infrastructure.GetRegexValidation(schoolDTO.RequesterEmail, infrastructure.EmailRegex); matched {
		c.JSON(fiber.Map{
			"errror": "RequesterEmail value is invalid",
		})
	}

	if matched, _ := infrastructure.GetRegexValidation(schoolDTO.URL, infrastructure.UrlRegex); matched {
		c.JSON(fiber.Map{
			"errror": "URL value is invalid",
		})
	}

	school := entity.School{
		UUID:          repository.GenerateID(),
		Name:          schoolDTO.Name,
		URL:           schoolDTO.RequesterEmail,
		GuardianEmail: schoolDTO.RequesterEmail,
	}

	infrastructure.CreateMongoDbService().CreateSchool(&school)

	return c.JSON(fiber.Map{
		"created": true,
	})
}
