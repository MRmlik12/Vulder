package entity

import "go.mongodb.org/mongo-driver/bson/primitive"

type School struct {
	ID            primitive.ObjectID `bson:"_id,omitempty"`
	UUID          string             `bson:"uuid"`
	Name          string             `bson:"name"`
	URL           string             `bson:"url"`
	GuardianEmail string             `bson:"guardian_email"`
}
