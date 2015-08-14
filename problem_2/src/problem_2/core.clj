(ns problem-2.core)

(defn character-count [text]
  (count text))

(defn say-count [text]
  (str text " has " (character-count text) " characters"))

(defn get-input []
  (println "Enter text: ")
  (read-line))

(defn character-counter []
    (println (say-count (get-input))))

(defn -main
  "character counter"
  [& args]
  (character-counter))
