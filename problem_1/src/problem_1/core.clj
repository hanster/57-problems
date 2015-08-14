(ns problem-1.core)

(defn- create-hello [name]
  (str "Hello " name "!"))

(defn- get-name []
  (println "Enter your name: ")
  (read-line))

(defn say-hello []
  (println (create-hello (get-name))))

(defn -main
  "Say hello"
  [& args]
  (say-hello-thread-first))
