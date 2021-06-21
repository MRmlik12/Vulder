package infrastructure

import (
	"github.com/mrmlik12/vulder/search/domain/entity"
	"go.mongodb.org/mongo-driver/bson"
)

func (mongoContext *MongoDbContext) CreateSchool(school *entity.School) {
	mongoContext.schoolsCollection.InsertOne(*mongoContext.ctx, school)
}

func (mongoContext *MongoDbContext) GetSchools(name string) (*entity.School, error) {
	filter, err := mongoContext.schoolsCollection.Find(*mongoContext.ctx, bson.M{"name": name})

	if err != nil {
		return nil, err
	}

	var school *entity.School
	err = filter.All(*mongoContext.ctx, &school)

	return school, err
}
