FROM node:16-alpine3.13 AS build

WORKDIR /src

COPY . .

RUN npm i
RUN npm run build

FROM nginx:1.19.10-alpine

COPY --from=build /src/build /usr/share/nginx/html
EXPOSE 80