import { ApolloServer } from "@apollo/server";
import { startStandaloneServer } from "@apollo/server/standalone";
const typeDefs = `#graphql
  type Game {
    id: ID!
    name: String!,
    platforms: [String!]!,
    reviews: [Review!]
  }

  type Review {
    id: ID!,
    content: String!,
    rating: String!,
    game: Game!,
    author: Author!
  }

  type Author {
    id: ID!,
    name: String!,
    reviews: [Review!]!
}

    type Query {
        games: [Game!]!,
        game(id: ID!): Game!,
        reviews: [Review!]!,
        review(id: ID!): Review!,
        authors: [Author!]!
        author(id: ID!): Author!
    }

    type Mutation {
        deleteGame(id: ID!): [Game],
        addGame(game: AddGameInput!): Game!
        updateGame(id: ID!, game: EditGameInput!): Game!
    },
    input AddGameInput {
        name: String!,
        platforms: [String!]!
    },
    input EditGameInput {
        name: String
        platforms: [String!]
    }
`;
let games = [
    { "id": "1", "name": "Halo 4", platforms: ["Xbox 360", "Xbox One"] },
    { "id": "2", "name": "Red Dead Redemption 2", platforms: ["PS5", "Xbox One"] },
    { "id": "3", "name": "Mario Cart", platforms: ["Nintendo Wii", "Switch"] },
];
let reviews = [
    { id: "101", "content": "Great game", "rating": "5", game_id: "1", author_id: "201", },
    { id: "102", "content": "Poor game", "rating": "1", game_id: "2", author_id: "202" },
    { id: "103", "content": "Awesome game", "rating": "4", game_id: "3", author_id: "203" },
    { id: "104", "content": "Average game", "rating": "3", game_id: "2", author_id: "201" },
    { id: "105", "content": "Not so great", "rating": "3", game_id: "3", author_id: "201" },
    { id: "106", "content": "Below par", "rating": "2", game_id: "2", author_id: "203" },
];
let authors = [
    { id: "201", "name": "John Smith" },
    { id: "202", "name": "Jane Doe" },
    { id: "203", "name": "Sue Bloggs" },
];
const resolvers = {
    Query: {
        games: () => games,
        game(_, args) {
            return games.find(game => game.id === args.id);
        },
        reviews: () => reviews,
        review(_, args) {
            return reviews.find(review => review.id === args.id);
        },
        authors() {
            return authors;
        },
        author(_, args) {
            return authors.find(author => author.id === args.id);
        },
    },
    Game: {
        reviews(parent) {
            // "parent" is the game.
            return reviews.filter(review => review.game_id === parent.id);
        }
    },
    Author: {
        reviews(parent) {
            return reviews.filter(review => review.author_id === parent.id);
        }
    },
    Review: {
        author(parent) {
            return authors.find(author => author.id === parent.author_id);
        },
        game(parent) {
            return games.find(game => game.id === parent.game_id);
        }
    },
    Mutation: {
        deleteGame(_, args) {
            games = games.filter(game => game.id !== args.id);
            return games;
        },
        addGame(_, args) {
            let game = {
                ...args.game,
                id: Math.floor(Math.random() * 1000).toString()
            };
            games.push(game);
            return game;
        },
        updateGame(_, args) {
            games = games.map((g) => {
                if (g.id === args.id) {
                    return {
                        ...g,
                        ...args.game
                    };
                }
                else {
                    return g;
                }
            });
            let game = games.find(game => game.id === args.id);
            return game;
        }
    }
};
const server = new ApolloServer({
    typeDefs,
    resolvers
});
const { url } = await startStandaloneServer(server, { listen: { port: 4000 } });
console.log(`Server ready at ${url}`);
