import { defineConfig } from 'vite'

// https://vitejs.dev/config/
export default defineConfig({
    root: 'src',
    base: '/SPATestOnGitHubPages/',
    build: {
        outDir: '../docs'
    },
    clearScreen: false,
    server: {
        port: 8080,
        watch: {
            ignored: [
                "**/*.fs" // Don't watch F# files
            ]
        }
    }
})